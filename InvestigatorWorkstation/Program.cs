﻿using InvestigatorWorkstation.Forms;
using InvestigatorWorkstation.Forms.Employee;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services;
using Services.Interfaces;
using Services.Interfaces.Employee;
using Services.Services.Employee;
using Storage;
using System;
using System.IO;
using System.Windows.Forms;

namespace InvestigatorWorkstation
{
    static class Program
    {  
        [STAThread]
        public static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = new HostBuilder()
                .ConfigureServices((_, services) =>
                {
                    var configuration = new ConfigurationBuilder()
                       .SetBasePath(Directory.GetCurrentDirectory())
                       .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                       .Build();

                    services
                        .AddDbContext<WorkstationContext>(options => options.UseSqlServer(configuration.GetConnectionString("WorkstationDBConnection")))
                        .AddScoped<IEmployeeService, EmployeeService>()
                        .AddScoped<IAuthService, AuthService>()
                        .AddScoped<IEmployeePositionService, EmployeePositionService>()
                        .AddScoped<IEmployeeRankService, EmployeeRankService>()
                        .AddScoped<MainForm>()
                        .AddScoped<AddEmployeeForm>()
                        .AddScoped<LoginForm>();

                }).Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;

                var mainForm = services.GetRequiredService<MainForm>();
                Application.Run(mainForm);
            };
        }
    }
}
