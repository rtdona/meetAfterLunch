using System;
using System.Threading.Tasks;

namespace graduate.AppClient.GoogleDrive
{
    public partial class GoogleServiceClient : IAppClient
    {
        public async Task<SpaceQuota> GetQuotaAsync()
        {
            var request = service.About.Get();
            request.Fields = "storageQuota";
            var response = await request.ExecuteAsync();

            var used = response.StorageQuota.Usage;
            var alloc = response.StorageQuota.Limit;

            return new SpaceQuota((ulong)used, (ulong)alloc);
        }
    }
}
