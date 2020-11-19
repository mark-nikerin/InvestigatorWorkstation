namespace InvestigatorWorkstation
{
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;
    using Storage;
    using System;
    using System.Windows.Forms; 

    static class Program
    {
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
                    services.AddLogging(configure => configure.AddConsole());
                    services.AddSingleton<Form1>();
                });

            var host = builder.Build();

            using (var setviceScope = host.Services.CreateScope())
            {
                var services = setviceScope.ServiceProvider;

                var form1 = services.GetRequiredService<Form1>();
                Application.Run(form1);
            };
        }
    }
}
