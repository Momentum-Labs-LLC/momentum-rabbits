using Amazon.Extensions.CognitoAuthentication;
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
            // Adds your own instance of Amazon Cognito clients 
            // cognitoIdentityProvider and cognitoUserPool are variables you would have instanciated yourself
            var provider = new Amazon.CognitoIdentityProvider.AmazonCognitoIdentityProviderClient();
            var cognitoUserPool = new CognitoUserPool(
                Configuration.GetValue<string>("COGNITO_USER_POOL_ID"),
                Configuration.GetValue<string>("COGNITO_USER_POOL_CLIENT_ID"),
                provider
            );
            services.AddSingleton<Amazon.CognitoIdentityProvider.IAmazonCognitoIdentityProvider>(provider);
            services.AddSingleton<CognitoUserPool>(cognitoUserPool);

            services.AddCognitoIdentity();

            services
                .AddLogging(config => 
                {
                    config.AddFilter("Microsoft", LogLevel.Debug);
                    config.AddFilter("System", LogLevel.Debug);
                    config.SetMinimumLevel(LogLevel.Debug);
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

            //app.UseAuthentication();
            app.UseAuthorization();
            app.UseCors();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        } // end method
    } // end class
} // end namespace