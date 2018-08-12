using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graduate.AppClient.Dropbox
{
    public partial class DropboxAppClient : IAppClient
    {
        public async Task<SpaceQuota> GetQuotaAsync()
        {
            var usage = await client.Users.GetSpaceUsageAsync();

            var used = usage.Used;
            var allocated = usage.Allocation.AsIndividual.Value.Allocated;

            return new SpaceQuota(used, allocated);
        }
    }
}
