using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;

/// <summary>
/// Google.Apis 패키지를 필요로 합니다.
/// NuGet 패키지 관리에서 검색해서 다운받거나 패키지 관리자 콘솔에서 다음을 실행
/// Install-Package Google.Apis
/// Install-Package Google.Apis.Auth
/// </summary>


namespace Unamed.Oauth2.GoogleDrive
{
    class GoogleAuthHelper : IOAuthHelper<DriveService>
    {

        private static readonly string AppKey = "658192927213-ve20900gvm7to12k7n9iusl9kvqdf2pm.apps.googleusercontent.com";
        private static readonly string AppSecret = "vngwnglRnHw58gySs-uz8U_5";
        private static readonly string ProjectName = "Integrated Cloud Storage Demo";
        private static readonly string[] Scopes = new[] { DriveService.Scope.DriveFile, DriveService.Scope.Drive };
        private static readonly string RedirectUri = "urn:ietf:wg:oauth:2.0:oob";

        private static readonly string DataStoreKey = "Google.Auth";
        private static readonly string DataFolder = "Google.Auth";

        private GoogleAuthorizationCodeFlow googleAuthcodeFlow;

        private UserCredential credential;

        public GoogleAuthHelper()
        {
            var initializer = new GoogleAuthorizationCodeFlow.Initializer
            {
                ClientSecrets = new ClientSecrets
                {
                    ClientId = AppKey,
                    ClientSecret = AppSecret
                },
                Scopes = Scopes,
                ProjectId = ProjectName,
                DataStore = new FileDataStore(DataFolder)
            };

            googleAuthcodeFlow = new GoogleAuthorizationCodeFlow(initializer);
        }

        public void StartAuthCodeUri()
        {
            var requestUrl = googleAuthcodeFlow.CreateAuthorizationCodeRequest(RedirectUri).Build();

            System.Diagnostics.Process.Start(requestUrl.ToString());
            
        }

        public async Task GetAccessTokenAsync(string code)
        {
            Google.Apis.Auth.OAuth2.Responses.TokenResponse token;
            // load token datastore
            try {
                token = await googleAuthcodeFlow.LoadTokenAsync(DataStoreKey, CancellationToken.None);
                await credential.RefreshTokenAsync(CancellationToken.None);
            }
            catch (Exception) {
                // exchange code for token, after than automatically store
                token = await googleAuthcodeFlow.ExchangeCodeForTokenAsync(DataStoreKey, code, RedirectUri, CancellationToken.None);
            }
            // token info
            Console.WriteLine("Acess Token: " + token.AccessToken);
            Console.WriteLine();
            Console.WriteLine("Access Token Expiration (sec): " + token.ExpiresInSeconds);
            Console.WriteLine();
            // new credential
            credential = new UserCredential(googleAuthcodeFlow, DataStoreKey, token);
        }

        public DriveService GetClient()
        {
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Drive API Sample",
            });
            return service;
        }
    }
}
