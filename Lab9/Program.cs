using Lab9.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddRazorPages(configure => configure.Conventions.AddPageRoute("/Emp/index", ""));

            builder.Services.AddDbContext<DataContext>
           (
               options => options
               .UseLazyLoadingProxies()
               .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
           );
            // Add services to the container.
           

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

       

            app.MapRazorPages();

            app.Run();
        }
    }
}