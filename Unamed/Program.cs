using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dropbox.Api;
using Google.Apis.Drive.v3;

namespace Unamed
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var instance = new Program();

            var task = Task.Run((Func<Task<int>>)instance.Run);

            task.Wait();
            
        }

        private async Task<int> Run()
        {
            //await GoogleDriveTest();
            //await DropboxTest();
            //await OneDriveTest();

            return 1;
        }
        /// <summary>
        /// 과정이 짜증나긴 해도 토큰 만료되면 자동으로 리프레쉬 해주는건 좋은듯
        /// 토큰 리프레쉬가 불가능한 경우 예외처리를 고려할 것.
        /// 
        /// 원래는 두단계로 나눠줘야 되는 과정인데 UI가 없으므로 주석처리함
        /// reciver.StartAuthCodeUri()는 웹 브라우저에 코드를 띄우는거고
        /// 그 아래쪽은 토큰 받아오는 과정임.
        /// 한번 토큰을 받아오면 저장하기 때문에 code를 입력하지 않아도 됨.
        /// </summary>
        /// <returns></returns>
        private async Task OneDriveTest()
        {
            Console.WriteLine("OneDrive Test");
            var reciver = new Oauth2.MicroSoft.MicrosoftAuthHelper();
            //reciver.StartAuthCodeUri();
            await reciver.GetAccessTokenAsync("여기에 code입력");
            var client = reciver.GetClient();
            var result = await client.Drive.Root.Children.Request().GetAsync();
            Console.WriteLine();

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(result);

            Console.WriteLine(json);
        }
        /// <summary>
        /// 토큰만료시 자동으로 리프레쉬되게 하려면 추가 작업이 필요함.
        /// 특수한 경우(6개월동안 미사용 등등) 리프레쉬가 불가능할 경우의 예외처리를 고려할것.
        /// 
        /// 두단계로 나눠지는점은 위와 동일함.
        /// </summary>
        /// <returns></returns>
        private async Task GoogleDriveTest()
        {

            Console.WriteLine("Google Drive Test");
            var reciver = new Oauth2.GoogleDrive.GoogleAuthHelper();
            //reciver.StartAuthCodeUri();
            //await reciver.GetAccessTokenAsync("enter code here");
            //var service = reciver.GetClient();

            //await GoogleUserTest(service);
        }

        private async Task GoogleUserTest(DriveService service)
        {
            var get = service.About.Get();
            get.Fields = "storageQuota,user";
            var response = await get.ExecuteAsync();
            Console.WriteLine("User: " + response.User.DisplayName);
            Console.WriteLine("Quota.limit: " + response.StorageQuota.Limit);
            Console.WriteLine("Quota.usage: " + response.StorageQuota.Usage);
            Console.WriteLine("Quota.usage in drive: " + response.StorageQuota.UsageInDrive);
            Console.WriteLine("Quota.usage in trash: " + response.StorageQuota.UsageInDriveTrash);
        }
        
        /// <summary>
        /// 제일 쉬운대신 제일 허술함. 아니 토큰이 만료가 없어? 우리야 편하다만..
        /// 
        /// 두단계로 나눠지는점은 위와 동일함.
        /// </summary>
        /// <returns></returns>
        private async Task DropboxTest()
        {
            Console.WriteLine("Dropboxtest");
            var reciver = new Oauth2.Dropbox.DropboxOAuthHelper();

            reciver.StartAuthCodeUri();

            //await reciver.CodeFlowGetAccessTokenAsync(code);
            //var client = reciver.GetClient();

            //await DropboxUserTest(client);
        }

        private async Task DropboxUserTest(DropboxClient client)
        {
            var full = await client.Users.GetCurrentAccountAsync();

            Console.WriteLine("Account id    : {0}", full.AccountId);
            Console.WriteLine("Country       : {0}", full.Country);
            Console.WriteLine("Email         : {0}", full.Email);
            Console.WriteLine("Is paired     : {0}", full.IsPaired ? "Yes" : "No");
            Console.WriteLine("Locale        : {0}", full.Locale);
            Console.WriteLine("Name");
            Console.WriteLine("  Display  : {0}", full.Name.DisplayName);
            Console.WriteLine("  Familiar : {0}", full.Name.FamiliarName);
            Console.WriteLine("  Given    : {0}", full.Name.GivenName);
            Console.WriteLine("  Surname  : {0}", full.Name.Surname);
            Console.WriteLine("Referral link : {0}", full.ReferralLink);

            if (full.Team != null) {
                Console.WriteLine("Team");
                Console.WriteLine("  Id   : {0}", full.Team.Id);
                Console.WriteLine("  Name : {0}", full.Team.Name);
            }
            else {
                Console.WriteLine("Team - None");
            }
        }
    }    
}
