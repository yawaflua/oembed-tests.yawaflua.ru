
namespace OembedTests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(k =>
                {
                    k.ConfigureKestrel(l => l.ListenAnyIP(80));
                    k.UseStartup<Startup>();
                })
                .Build().Run();           
        }
    }
}
