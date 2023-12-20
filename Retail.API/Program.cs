
using Microsoft.EntityFrameworkCore;
using Retail.BL;
using Retail.DAL;

namespace Retail.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            #region CORS
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("CORSpolicy", policy =>
                {
                    policy.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                });
            });
            #endregion

            #region Database

            builder.Services.AddDbContext<RetailContext>(options =>
                         options.UseSqlServer(builder.Configuration.GetConnectionString("cs"))
            );
            #endregion

            #region InjectionForRepo

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IProductRepo, ProductRepo>();
            builder.Services.AddScoped<ICategoryRepo, CategoryRepo>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            #endregion

            #region InjectionForMangers
            builder.Services.AddScoped<ICategoryManager, CategoryManager>();
            builder.Services.AddScoped<IProductManager, ProductManager>();
            #endregion

            var app = builder.Build();

            #region CORS
            app.UseCors("CORSpolicy");
            #endregion

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}