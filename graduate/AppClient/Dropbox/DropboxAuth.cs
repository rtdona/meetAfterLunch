using System;
using System.Diagnostics;
using System.Threading.Tasks;

using Dropbox.Api;
/// <summary>
///  Dropbox.Api 패키지를 필요로 합니다.
///  NuGet 패키지 관리에서 검색해서 다운받거나 패키지 관리자 콘솔에서 다음을 실행
///  PM> Install-Package Dropbox.Api
/// </summary>

namespace graduate.AppClient.Dropbox
{
    public partial class DropboxAppClient : IAppClient
    {
        private static readonly string AppKey = "k1h1uuncs2aozk1";
        private static readonly string AppSecret = "6gs6v81e6mw412k";
        private static readonly string RedirectUri = "";
        private static readonly string AgentName = "Integrated Cloud Storage Demo";

        //public static bool isConnected;

        private DropboxClient client;

        public Process StartAuthCodeUri()
        {
            DropboxCertHelper.InitializeCertPinning();
            // state field를 보안에 사용하려면 추가 
            // var state = Guid.NewGuid().ToString("N");
            var authorizeUri = DropboxOAuth2Helper.GetAuthorizeUri(OAuthResponseType.Code,
                AppKey, RedirectUri);

            return Process.Start(authorizeUri.ToString());
        }

        public async Task CodeFlowGetAccessTokenAsync(string code)
        {
            
            if (String.IsNullOrEmpty(graduate.Properties.DropboxSettings.Default.AccessToken)) {
                OAuth2Response response = await DropboxOAuth2Helper.ProcessCodeFlowAsync(code, AppKey, AppSecret, RedirectUri).ConfigureAwait(false);

                // AccessToken과 Uid를 저장
                graduate.Properties.DropboxSettings.Default.AccessToken = response.AccessToken;
                graduate.Properties.DropboxSettings.Default.Uid = response.Uid;
                graduate.Properties.DropboxSettings.Default.Save();
            }
        }

        public async Task ConnectAsync()
        {
            await Task.Run(() => {
                var token = graduate.Properties.DropboxSettings.Default.AccessToken;

                if (string.IsNullOrEmpty(token)) {
                    throw new OAuth2Exception("Access Token Missing from Cache");
                }

                var config = new DropboxClientConfig(AgentName);
                client = new DropboxClient(token, config);
            }).ConfigureAwait(false);
        }
    }
}
