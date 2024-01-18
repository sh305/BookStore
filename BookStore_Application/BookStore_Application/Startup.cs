namespace BookStore_Application
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

        }
        public void Configure(IApplicationBuilder app,IWebHostEnvironment env)
        {
            // Configure Custom MiddelWare
            //app.Use(async (context, next) => 
            //{
            //    await context.Response.WriteAsync("Hello From first MiddelWare");
            //    await next();
            //});
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                //endpoints.Map("/", async context =>
                //{
                //    // Get the environment Name
                //    await context.Response.WriteAsync(env.EnvironmentName);
                //    await context.Response.WriteAsync("Hello Startup");

                //});
            });

        }

    }
}
