using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using BookStoreWebapi.DBOperations;

namespace BookStoreWebapi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Add DbContext with InMemory database or another database provider
            builder.Services.AddDbContext<BookStorageDBContext>(options =>
                options.UseInMemoryDatabase("BookStoreDatabase")); // In-memory veritabanı kullanılıyor. Yerine SQL kullanabilirsiniz.

            var app = builder.Build();

            // Initialize the database with data
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                // Call DataGenerator to seed the database
                DataGenerator.Initialize(services);
            }

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
