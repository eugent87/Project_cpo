

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