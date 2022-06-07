using Microsoft.OpenApi.Models;
using System.Reflection;
using Wormhunt.Core.Services.Hunting;

namespace Wormhunt
{
    public static class Bootstrapper
    {
        public static void Bootstrap(WebApplicationBuilder builder)
        {
            BuildAspNetCoreDefaultServices(builder);
            BuildSwaggerDocumentationGeneration(builder);
            BuildWormhuntDependencies(builder);
        }

        private static void BuildWormhuntDependencies(WebApplicationBuilder builder)
        {
            builder.Services
                .AddScoped<IHuntingService, HuntingService>()
                .AddScoped<IWormAttractionStrategy, RandomWormAttractionStrategy>();
        }

        public static void Bootstrap(WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                ConfigureDevelopmentApp(app);
            }
            else
            {
                ConfigureProductionApp(app);
            }

            ConfigureApp(app);
        }

        private static void ConfigureApp(WebApplication app)
        {
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action=Index}/{id?}");

            app.MapFallbackToFile("index.html");
        }

        private static void ConfigureProductionApp(WebApplication app)
        {
            // Configure the HTTP request pipeline.
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        private static void ConfigureDevelopmentApp(WebApplication app)
        {
            ConfigureSwaggerUi(app);
        }

        private static void BuildAspNetCoreDefaultServices(WebApplicationBuilder builder)
        {
            builder.Services.AddControllersWithViews();
        }

        private static void ConfigureSwaggerUi(WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        private static void BuildSwaggerDocumentationGeneration(WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "ToDo API",
                    Description = "An ASP.NET Core Web API for managing ToDo items",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "Example Contact",
                        Url = new Uri("https://example.com/contact")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Example License",
                        Url = new Uri("https://example.com/license")
                    }
                });

                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
            });
        }
    }
}
