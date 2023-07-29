using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Aquc.CountToDo.Service
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            /*
            using IHost host = new HostBuilder()
                .UseWindowsService(option =>
                {
                    option.ServiceName = "Aquc.CountToDo";
                })
                .ConfigureLogging(builder =>
                {
                    builder.ClearProviders();
                    builder.AddConsole();
                    builder.AddFile();
                })
                .ConfigureServices(container =>
                {
                    container.AddHostedService<Service>();
                })
                .Build();
            */
            var i = new Stackbricks.Interop.StackbricksInterop(new FileInfo("Aquc.Stackbricks.exe"));
            var r = await i.Update();
            if (r.IsSuccess)
            {

                Console.WriteLine(r.Value!.version);
                Console.WriteLine(r.Value!.needUpdate);
            }
            else
            {
                Console.WriteLine(r.Exception!.message);
                Console.WriteLine(r.Exception!.type);
            }
        }

    }
}