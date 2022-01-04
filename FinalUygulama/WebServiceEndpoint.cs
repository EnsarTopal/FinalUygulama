using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using FinalUygulama.Data;
using FinalUygulama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace FinalUygulama
{
    public static class WebServiceEndpoint
    {

        private static string BASEURL = "api/Haber";



        public static void MapWebService(this IEndpointRouteBuilder app)

        {

            //Haber

            app.MapGet($"{BASEURL}/{{id}}", async context =>
            {

                long key = long.Parse(context.Request.RouteValues["id"] as string);

                FinalUygulamaContext data = context.RequestServices.GetService<FinalUygulamaContext>();

                Haber p = data.Haber.Find(key);

                if (p == null)

                {

                    context.Response.StatusCode = StatusCodes.Status404NotFound;

                }

                else

                {

                    context.Response.ContentType = "application/json";

                    await context.Response

                        .WriteAsync(JsonSerializer.Serialize<Haber>(p));

                }

            });



            app.MapGet(BASEURL, async context =>
            {

                FinalUygulamaContext data = context.RequestServices.GetService<FinalUygulamaContext>();

                context.Response.ContentType = "application/json";

                await context.Response.WriteAsync(JsonSerializer

                    .Serialize<IEnumerable<Haber>>(data.Haber));

            });



            app.MapPost(BASEURL, async context =>
            {

                FinalUygulamaContext data = context.RequestServices.GetService<FinalUygulamaContext>();

                Haber p = await

                    JsonSerializer.DeserializeAsync<Haber>(context.Request.Body);

                await data.AddAsync(p);

                await data.SaveChangesAsync();

                context.Response.StatusCode = StatusCodes.Status200OK;

            });


        }

    }
}

