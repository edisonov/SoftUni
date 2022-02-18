using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using BasicWebServer.Server;
using BasicWebServer.Server.Controllers;
using BasicWebServer.Server.HTTP;
using BasicWebServer.Server.Responses;
using BasicWebServer.Server.Routing;

namespace BasicWebServer.Demo
{
    public class Startup
    {
        public static async Task Main()
        {
            await new HttpServer(routes => routes
                .MapControllers())
                .Start();
        }
    }
}
