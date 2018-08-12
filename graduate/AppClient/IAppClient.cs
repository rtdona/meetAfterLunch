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
    }
}