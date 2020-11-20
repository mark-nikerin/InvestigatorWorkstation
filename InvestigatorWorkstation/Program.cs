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
                    services.AddSingleton<Form1>();
                });

            var host = builder.Build();

            using (var setviceScope = host.Services.CreateScope())
            {
                var services = setviceScope.ServiceProvider;

                var form1 = services.GetRequiredService<Form1>();
                var workstationContext = services.GetRequiredService<WorkstationContext>();
                Application.Run(form1);
            };
        }
    }
}
