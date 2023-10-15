using DataAccess.Data;
using DataAccess.Data.Entities;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SocialNetworkClone.Helpers;

namespace DataAccess
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            string connectionString = builder.Configuration.GetConnectionString("LocalDb");

            // add FluentValidator with validation classes
            builder.Services.AddFluentValidationAutoValidation();
            builder.Services.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<SocialNetworkDbContext>(opts => opts.UseSqlServer(connectionString));

            builder.Services.AddIdentity<User, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
            })
            .AddDefaultTokenProviders()
            .AddDefaultUI()
            .AddEntityFrameworkStores<SocialNetworkDbContext>();
            var app = builder.Build();

            // identity roles and admin user initialization
            using (IServiceScope scope = app.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;

                // seed roles
                SeedExtensions.SeedRoles(serviceProvider).Wait();

                // seed admin
                SeedExtensions.SeedAdmin(serviceProvider).Wait();
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapRazorPages();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
