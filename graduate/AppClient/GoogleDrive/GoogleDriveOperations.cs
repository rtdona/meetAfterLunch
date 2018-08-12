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

            long used = response.StorageQuota.Usage ?? default(long);
            long alloc = response.StorageQuota.Limit ?? default(long);

            return new SpaceQuota((ulong)used, (ulong)alloc);
        }
    }
}
