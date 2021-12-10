using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace PrimeiraApiWorkshop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

/*
    dotnet add package Microsoft.EntityFrameworkCore --version 5.0.2
    dotnet add package Microsoft.EntityFrameworkCore --version 5.0.2
    dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 5.0.2
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.2
    dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.2
    dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 5.0.2
*/

/*
    Quais são as notações de coluna padrões para se modelar um sistema.
    Required, minValue, defaultValue, etc.
    
    REGRAS DE NEGÓCIO

    O que são DTO's?
*/













//AUTENTICAÇÃO