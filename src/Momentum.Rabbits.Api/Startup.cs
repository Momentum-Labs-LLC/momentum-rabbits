using Momentum.NodaTime;
using Momentum.Rabbits.DynamoDb.Rabbits;

namespace Momentum.Rabbits.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        } // end method

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCognitoIdentity();

            services
                .AddLogging(config => 
                {
                    config.AddFilter("Microsoft", LogLevel.Warning);
                    config.AddFilter("System", LogLevel.Warning);
                    config.SetMinimumLevel(LogLevel.Error);
                    config.AddLambdaLogger();
                })
                .AddMemoryCache()
                .AddSingleton<IConfiguration>(Configuration)
                .AddNodaTime()
                .AddRabbitService()
                .AddEndpointsApiExplorer()
                .AddSwaggerGen()
                .AddControllers();
        } // end method

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            } // end if

            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCors();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        } // end method
    } // end class
} // end namespace