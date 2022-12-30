using System;
using Cornea.Application.Interfaces.Contexts;
using Cornea.Application.Services.Customer.Commands.AddCustomer;
using Cornea.Application.Services.Customer.Commands.DeleteCustomer;
using Cornea.Application.Services.Customer.Commands.EditCustomer;
using Cornea.Application.Services.Customer.Queries.FindCustomers;
using Cornea.Application.Services.Customer.Queries.GetCustomers;
using Cornea.Application.Services.Factor.Commands.AddFactor;
using Cornea.Application.Services.Factor.Commands.DeleteFactor;
using Cornea.Application.Services.Factor.Commands.EditFactor;
using Cornea.Application.Services.Factor.Queries.FindFactor;
using Cornea.Application.Services.Factor.Queries.GetFactor;
using Cornea.Application.Services.Product.Commands.AddProduct;
using Cornea.Application.Services.Product.Commands.DeleteProduct;
using Cornea.Application.Services.Product.Commands.EditProduct;
using Cornea.Application.Services.Product.Queries.FindProduct;
using Cornea.Application.Services.Product.Queries.GetProduct;
using Cornea.Application.Services.Project.Commands.AddProject;
using Cornea.Application.Services.Project.Commands.DeleteProject;
using Cornea.Application.Services.Project.Commands.EditProject;
using Cornea.Application.Services.Project.Queries.FindProjects;
using Cornea.Application.Services.Project.Queries.GetProjects;
using Cornea.Application.Services.Task.Commands.AddTask;
using Cornea.Application.Services.Task.Commands.DeleteTask;
using Cornea.Application.Services.Task.Commands.EditTask;
using Cornea.Application.Services.Task.Queries.FindTasks;
using Cornea.Application.Services.Task.Queries.GetTasks;
using Cornea.Application.Services.Users.Commands.DeleteUser;
using Cornea.Application.Services.Users.Commands.EditUser;
using Cornea.Application.Services.Users.Queries.Signin;
using Cornea.Application.Services.Users.Commands.RegisterUsers;
using Cornea.Application.Services.Users.Queries.FindUsers;
using Cornea.Application.Services.Users.Queries.GetRoles;
using Cornea.Application.Services.Users.Queries.GetUsers;
using Cornea.Persistence.Contexts;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Cornea.Site
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options =>
            {
                options.Cookie.Name = "UserLoginCookie"; // Name of cookie 
                options.Cookie.SameSite = SameSiteMode.None;
                options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
                options.ExpireTimeSpan = TimeSpan.FromSeconds(1);

                options.LoginPath = "/Home/Signin";
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            services.AddScoped<IDataBaseContext, DataBaseContext>();
            services.AddScoped<IGetUsersService, GetUsersService>();
            services.AddScoped<IAddUsersService, AddUsersService>();
            services.AddScoped<IFindUsersService, FindUsersService>();
            services.AddScoped<IEditUserService, EditUserService>();
            services.AddScoped<IGetRolesService, GetRolesService>();
            services.AddScoped<IRegisterUserService, RegisterUserService>();
            services.AddScoped<IUserLoginService, UserLoginService>();
            services.AddScoped<IDeleteUserService, DeleteUserService>();
            services.AddScoped<ISaveFileDirection, SaveFileDirection>();
            services.AddScoped<IChangePasswordService, ChangePasswordService>();

            //Projects
            services.AddScoped<IGetProjectsService, GetProjectsService>();
            services.AddScoped<IAddProjectService, AddProjectService>();
            services.AddScoped<IEditProjectService, EditProjectService>();
            services.AddScoped<IFindProjectsService, FindProjectsService>();
            services.AddScoped<IDeleteProjectService, DeleteProjectService>();

            //Tasks
            services.AddScoped<IGetTasksService, GetTasksService>();
            services.AddScoped<IAddTaskService, AddTaskService>();
            services.AddScoped<IEditTaskService, EditTaskService>();
            services.AddScoped<IEditStatusService, EditStatusService>();
            services.AddScoped<IFindTasksService, FindTasksService>();
            services.AddScoped<IDeleteTaskService,DeleteTaskService>();

            //Customers
            services.AddScoped<IGetCustomersService, GetCustomersService>();
            services.AddScoped<IAddCustomerService, AddCustomerService>();
            services.AddScoped<IEditCustomerService, EditCustomerService>();
            services.AddScoped<IFindCustomersService, FindCustomersService>();
            services.AddScoped<IDeleteCustomerService, DeleteCustomerService>();
            ;
            //Products
            services.AddScoped<IGetProductsService, GetProductsService>();
            services.AddScoped<IAddProductService, AddProductService>();
            services.AddScoped<IEditProductService, EditProductService>();
            services.AddScoped<IDeleteProductService, DeleteProductService>();
            services.AddScoped<IFindProductService, FindProductService>();

            //Factors
            services.AddScoped<IGetFactorsService, GetFactorsService>();
            services.AddScoped<IAddFactorService, AddFactorService>();
            services.AddScoped<IEditFactorService, EditFactorService>();
            services.AddScoped<IDeleteFactorService, DeleteFactorService>();
            services.AddScoped<IFindFactorService, FindFactorService>();

            ////
            services.AddRazorPages().AddRazorRuntimeCompilation();

            string contectionString = @"Data Source=localhost; Initial Catalog=CorneaDb; Integrated Security=True;";
            services.AddEntityFrameworkSqlServer().AddDbContext<DataBaseContext>(option => option.UseSqlServer(contectionString));
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Authentication}/{action=Signin}/{id?}");
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Main}/{id?}");
            });
        }
    }
}
