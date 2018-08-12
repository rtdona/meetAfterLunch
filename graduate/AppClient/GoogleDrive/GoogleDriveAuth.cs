using System;
using System.Diagnostics;
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
/// Install-Package Google.Apis.Drive.v3
/// </summary>


namespace graduate.AppClient.GoogleDrive
{
    public partial class GoogleServiceClient : IAppClient
    {

        private static readonly string AppKey = "658192927213-ve20900gvm7to12k7n9iusl9kvqdf2pm.apps.googleusercontent.com";
        private static readonly string AppSecret = "vngwnglRnHw58gySs-uz8U_5";
        private static readonly string ProjectName = "Integrated Cloud Storage Demo";
        private static readonly string[] Scopes = new[] { DriveService.Scope.DriveFile, DriveService.Scope.Drive };
        private static readonly string RedirectUri = "urn:ietf:wg:oauth:2.0:oob";

        private static readonly string DataStoreKey = "Google.Auth";
        private static readonly string DataFolder = "Google.Auth";

        private static GoogleAuthorizationCodeFlow googleAuthcodeFlow;

        private UserCredential credential;

        private DriveService service;

        static GoogleServiceClient()
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

        public Process StartAuthCodeUri()
        {
            var requestUrl = googleAuthcodeFlow.CreateAuthorizationCodeRequest(RedirectUri).Build();

            return Process.Start(requestUrl.ToString());
        }

        public async Task CodeFlowGetAccessTokenAsync(string code)
        {
            // exchange code for token, after than automatically store
            var token = await googleAuthcodeFlow.ExchangeCodeForTokenAsync(DataStoreKey, code, RedirectUri, CancellationToken.None).ConfigureAwait(false);
            credential = new UserCredential(googleAuthcodeFlow, DataStoreKey, token);
        }
        

        public async Task ConnectAsync()
        {
            try {
                await credential.RefreshTokenAsync(CancellationToken.None).ConfigureAwait(false);
            }
            catch (NullReferenceException) {
                var token = await googleAuthcodeFlow.LoadTokenAsync(DataStoreKey, CancellationToken.None).ConfigureAwait(false);
                credential = new UserCredential(googleAuthcodeFlow, DataStoreKey, token);
            }

            service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ProjectName
            });
        }
    }
}
