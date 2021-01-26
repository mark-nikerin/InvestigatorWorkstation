namespace InvestigatorWorkstation
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting; 
    using Services;
    using Services.Interfaces;
    using Services.Services;
    using Storage;
    using System;
    using System.IO;
    using System.Windows.Forms;

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
                        .AddScoped<MainForm>()
                        .AddScoped<RegisterForm>()
                        .AddScoped<LoginForm>()
                        .AddScoped<IPasswordService, PasswordService>()
                        .AddScoped<IEmployeeService, EmployeeService>()
                        .AddScoped<IAuthService, AuthService>();
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
