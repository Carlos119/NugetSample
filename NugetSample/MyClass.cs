using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NugetSample
{
    class MyClass
    {
        async Task DownloadAsync() {

            HttpClient httoClient = new HttpClient();
            await httoClient.GetStringAsync("");
        }
    }
}
