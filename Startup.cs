namespace OembedTests
{
    public class Startup
    {
        private readonly IConfiguration configuration;
        public static IServiceProvider serviceProvider;
        
        public Startup()
        {
            configuration = new ConfigurationBuilder()
                .AddEnvironmentVariables(prefix: "m.")
                .AddJsonFile("appsettings.json", optional: true)
                .Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services
                .AddSwaggerGen()
                .AddSingleton(configuration)
                .AddEndpointsApiExplorer();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwagger(c =>
            {
                c.RouteTemplate = "/swagger/v1/swagger.json";
            });
            
            app.UseStaticFiles();
            app.UseRouting();
            app.UseCors(k => { k.AllowAnyHeader(); k.AllowAnyMethod(); k.AllowAnyOrigin(); k.WithMethods("POST", "GET"); });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}