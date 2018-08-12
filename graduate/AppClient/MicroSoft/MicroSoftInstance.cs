using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graduate.AppClient.MicroSoft
{
    public partial class MicrosoftGraphClient : IAppClient
    {
        private static readonly MicrosoftGraphClient _instance = new MicrosoftGraphClient();

        private MicrosoftGraphClient() { }

        public static MicrosoftGraphClient Instance {
            get {
                return _instance;
            }
        }
    }
}
