namespace InvestigatorWorkstation
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;
    using Services;
    using Services.Interfaces;
    using Storage;
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Windows.Forms; 

    static class Program
    {
        private static readonly IConfiguration _configuration;

        static Program()
        {
            _configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }
         
        [STAThread]
        public static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             
            var builder = new HostBuilder()
                .ConfigureServices((hostContext, services) =>
 
                {
                    /* services.AddDbContext<WorkstationContext>(options =>
                    {
                        options.UseSqlServer("Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;");
                    });*/
                    services.AddDbContext<WorkstationContext>();
                    services.AddSingleton<MainForm>();
                    services.AddSingleton<LoginForm>();
                    services.AddSingleton<RegisterForm>();
                    services.AddTransient<IPasswordService, PasswordService>();
                    services.AddTransient<IAuthService, AuthService>();

                    services.AddLogging(configure => configure.AddConsole());

                });

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                   
                var loginForm = services.GetRequiredService<LoginForm>();
                Application.Run(loginForm);
            };
        }
    }
}
