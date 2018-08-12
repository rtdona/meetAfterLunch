using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace graduate.AppClient
{
    interface IAppClient
    {
        Process StartAuthCodeUri();
        Task    CodeFlowGetAccessTokenAsync(string code);
        Task    ConnectAsync();
        Task<SpaceQuota> GetQuotaAsync();
    }

    public class SpaceQuota
    {
        public ulong Allocated { get; }
        public ulong Used { get; }

        public SpaceQuota (ulong used, ulong allocated)
        {
            this.Used = used;
            this.Allocated = allocated;
        }
    }
}