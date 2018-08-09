using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Dropbox.Api;

/// <summary>
///  Dropbox.Api 패키지를 필요로 합니다.
///  NuGet 패키지 관리에서 검색해서 다운받거나 패키지 관리자 콘솔에서 다음을 실행
///  PM> Install-Package Dropbox.Api
/// </summary>

namespace Unamed.Oauth2.Dropbox
{
    public class DropboxOAuthHelper : IOAuthHelper<DropboxClient>
    {
        private static readonly string AppKey = "k1h1uuncs2aozk1";
        private static readonly string AppSecret = "6gs6v81e6mw412k";
        private static readonly string RedirectUri = "";
        private static readonly string AgentName = "Integrated Cloud Storage Demo";

        //public static bool isConnected;

        public void StartAuthCodeUri()
        {
            DropboxCertHelper.InitializeCertPinning();
            // var state = Guid.NewGuid().ToString("N");
            var authorizeUri = DropboxOAuth2Helper.GetAuthorizeUri(OAuthResponseType.Code,
                AppKey, RedirectUri);

            // 웹 브라우저에서 드랍박스 인증 화면이 나타납니다.
            System.Diagnostics.Process.Start(authorizeUri.ToString());

            // TODO: 인증코드 입력 Form을 띄우고, 사용자가Code값을 입력합니다.
        }

        public async Task CodeFlowGetAccessTokenAsync(string code)
        {
            if (String.IsNullOrEmpty(DropboxSettings.Default.AccessToken)) {
                OAuth2Response response = await DropboxOAuth2Helper.ProcessCodeFlowAsync(code, AppKey, AppSecret, RedirectUri);

                // AccessToken과 Uid를 저장
                DropboxSettings.Default.AccessToken = response.AccessToken;
                DropboxSettings.Default.Uid = response.Uid;
                DropboxSettings.Default.Save();
            }
        }

        public DropboxClient GetClient()
        {
            var token = DropboxSettings.Default.AccessToken;

            if(string.IsNullOrEmpty(token)) {
                Console.WriteLine("You must acquire Access Token first");
                return null;
            }
            
            try {
                // HttpClient를 미설정시 default httpClient를 사용합니다.
                // 타임아웃등을 설정하려면 examples/simpletest/program.cs line 64 참조
                var config = new DropboxClientConfig(AgentName);
                
                return new DropboxClient(token, config);
            }
            catch (HttpException e) {
                Console.WriteLine("Exception reported from RPC layer");
                Console.WriteLine("    Status code: {0}", e.StatusCode);
                Console.WriteLine("    Message    : {0}", e.Message);
                if (e.RequestUri != null) {
                    Console.WriteLine("    Request uri: {0}", e.RequestUri);
                }
                return null;
            }
        }
    }
}
