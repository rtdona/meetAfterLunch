using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graduate.AppClient.GoogleDrive
{
    public partial class GoogleServiceClient : IAppClient
    {
        private static readonly GoogleServiceClient _instance = new GoogleServiceClient();

        private GoogleServiceClient() { }

        public static GoogleServiceClient Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
