﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Owin;
using Microsoft.Owin.Hosting;

namespace KatanaIntro
{
    using System.IO;
    using System.Web.Http;
    using AppFunc = Func<IDictionary<string, object>, Task>;

    // Commmenting out because IIS doesn't need this
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string uri = "http://localhost:8080";
    //        using (WebApp.Start<Startup>(uri))
    //        {
    //            Console.WriteLine("Started!");
    //            Console.ReadKey();
    //            Console.WriteLine("Stopping!");
    //        }
    //    }
    //}

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.Use(async (environment, next) => 
            //{
            //    foreach (var pair in environment.Environment)
            //        Console.WriteLine("{0}:{1}", pair.Key, pair.Value);

            //    await next();
            //});

            app.Use(async (environment, next) =>
            {
                Console.WriteLine("Requesting: " + environment.Request.Path);               
                await next();
                Console.WriteLine("Response: " + environment.Response.StatusCode);
            });

            ConfigureWebApi(app);

            // Looks prettier if you use extension method below
            //app.Use<HelloWorldComponent>();
            app.UseHelloWorld();

            //app.UseWelcomePage();

            //app.Run(ctx =>
            //{
            //    return ctx.Response.WriteAsync("Hello World!");
            //});
        }

        private void ConfigureWebApi(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                "DefaultApi", 
                "api/{controller}/{id}", 
                new { id = RouteParameter.Optional });
            app.UseWebApi(config);
        }
    }

    public static class AppBuilderExtensions
    {
        public static void UseHelloWorld(this IAppBuilder app)
        {
            app.Use<HelloWorldComponent>();
        }
    }

    // This is an OWIN component, also known as middleware, called middleware because it sits in the middle of a processing pipeline
    public class HelloWorldComponent
    {
        AppFunc _next;

        // You can use the shortcut with the using AppFunc above instead of this
        //public HelloWorldComponent(Func<IDictionary<string, object>, Task> next) {}

        public HelloWorldComponent(AppFunc next)
        {
            // You need a constructor that matches AppFunc signature so Kitana can call the next middleware component in the pipline
            _next = next;
        }

        public Task Invoke(IDictionary<string, object> environment)
        {
            var response = environment["owin.ResponseBody"] as Stream;
            using (var writer = new StreamWriter(response))
            {
                return writer.WriteAsync("Hello!!");
            }
            //await _next(environment);
        }
    }
}
