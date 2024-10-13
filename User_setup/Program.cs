using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json;
using User_Interface.Main_page;

namespace User_setup
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
           

       
            ApplicationConfiguration.Initialize();
            long ID = 314627387;//менять

            Application.Run(new Login_page());
           
        }
    }
}