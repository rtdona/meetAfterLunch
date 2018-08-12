using System;
using System.Threading.Tasks;

namespace graduate.AppClient.MicroSoft
{
    public partial class MicrosoftGraphClient : IAppClient
    {
        public async Task<SpaceQuota> GetQuotaAsync()
        {
            var response = await client.Drive.Request().GetAsync();
            long used = response.Quota.Used ?? default(long);
            long total = response.Quota.Total ?? default(long);

            return new SpaceQuota((ulong)used, (ulong)total);
        }
    }
}
