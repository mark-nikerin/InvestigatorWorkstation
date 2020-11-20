namespace InvestigatorWorkstation
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;
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
                    services.AddSingleton<MainForm>(); 
                   /* services.AddDbContext<WorkstationContext>(options =>
                    {
                        options.UseSqlServer("Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;");
                    });*/
                    services.AddLogging(configure => configure.AddConsole());
                    services.AddSingleton<LoginForm>(); 
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
