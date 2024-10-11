using System.Text.Json;
using User_Interface.Main_page;

namespace User_setup
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string json_path = "C:/Users/glkru/Source/Repos/Gandoler/Project_cpo/config.json";


            ApplicationConfiguration.Initialize();
            long ID = 314627387;//менять

            Application.Run(new Main_page(json_path,ID));
        }
    }
}