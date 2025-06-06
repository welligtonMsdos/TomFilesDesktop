using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms.Design;
using TomFilesDesktop.Interfaces;
using TomFilesDesktop.Repositories;
using TomFilesDesktop.Service;

namespace TomFilesDesktop
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceCollection = new ServiceCollection(); 
            ConfigureServices(serviceCollection); 
            var serviceProvider = serviceCollection.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.SetCompatibleTextRenderingDefault(false);           
            Application.Run(new FrmPrincipal(serviceProvider.GetService<IFileService>(), 
                                             serviceProvider.GetService<IFolderService>()));
        }

        private static void ConfigureServices(IServiceCollection services) 
        { 
            services.AddSingleton<IFileService, FileService>();
            services.AddSingleton<IFileRepository, FileRepository>();
            services.AddSingleton<IFolderService, FolderService>();
            services.AddSingleton<IFolderRepository, FolderRepository>();
        }
    }
}