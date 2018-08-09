using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

using Microsoft.Graph;
using Microsoft.Identity.Client;

/// <summary>
/// OneDrive 패키지를 필요로 합니다.
/// NuGet 패키지 관리에서 검색해서 다운받거나 패키지 관리자 콘솔에서 다음을 실행
/// Install-Package Microsoft.OneDriveSDK
/// InstallInstall-Package Microsoft.Graph
/// Install-Package Microsoft.Identity.Client -Version 1.1.4-preview0002 (버전이 바뀌룻 있으니 체크)
/// 이놈들이 제일 나쁨 나쁜놈들임.. 세개로 나눠놓지를 않나 인증 API는 버전업해서 새로 개발하질 않나.
/// </summary>
/// 
namespace Unamed.Oauth2.MicroSoft
{
    class MicrosoftAuthHelper : IOAuthHelper<GraphServiceClient>
    {
        private static readonly string AppKey = "98faec43-9727-4675-a7a2-c59e212e38a0";
        private static readonly string AppSecret = "kdvxuNXHN80}*pmWHP376]%";
        private static readonly string[] Scopes = new[] {"Files.ReadWrite.All"};
        //private static readonly string RedirectUri = "urn:ietf:wg:oauth:2.0:oob";
        private static readonly string RedirectUri = "https://gwtwind.github.io/auth";
        //private static readonly string RedirectUri = "https://login.live.com/oauth20_desktop.srf";

        // 로그인 힌트는 로그인 하는 유저가 입력하는 필드인가? xxx@gmail.com 같은것? 
        private static readonly string UPN = null;

        private static string AcessToken;

        private static ConfidentialClientApplication identityApp =
            new ConfidentialClientApplication(
                AppKey, RedirectUri, new ClientCredential(AppSecret), TokenCacheHelper.GetUserCache(), null);
        

        public void StartAuthCodeUri()
        {
            var task = identityApp.GetAuthorizationRequestUrlAsync(Scopes, UPN, null);

            Task.Run(() => task);
            task.Wait();

            var uri = task.Result;

            Console.WriteLine(uri.ToString());
            

            System.Diagnostics.Process.Start(uri.ToString());
        }

        public async Task GetAccessTokenAsync(string code)
        {
            try {
                IUser user = identityApp.Users.FirstOrDefault();
                var result = await identityApp.AcquireTokenSilentAsync(Scopes, user);
                AcessToken = result.AccessToken;
                Console.WriteLine("...Load from cache");
            }
            catch (Exception) {
                var result = await identityApp.AcquireTokenByAuthorizationCodeAsync(code, Scopes);
                AcessToken = result.AccessToken;
            }
            Console.WriteLine("AccessToken: " + AcessToken);
        }

        public GraphServiceClient GetClient()
        {
            var graphServiceClient = new GraphServiceClient(new DelegateAuthenticationProvider((requestMessage) => {
                requestMessage
                    .Headers
                    .Authorization = new AuthenticationHeaderValue("bearer", AcessToken);

                return Task.FromResult(0);
            }));
            return graphServiceClient;
        }
    }
}
