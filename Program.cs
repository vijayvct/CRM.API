using CRM.API.Data;
using Microsoft.EntityFrameworkCore;

namespace CRM.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var config = builder.Configuration;

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddDbContext<CRMAPIContext>(options =>
            options.UseSqlServer(config.GetConnectionString("XasseeTrainingCRMApiContext")));

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
