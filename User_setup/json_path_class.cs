using MySql.Data.MySqlClient;


namespace User_Interface
{
    static class json_path_class
    {
        static string json_path = "Data/Data_config_for_app.json";
        

        static public string get_absolut_path()
        {
           
            string absolutePath = Path.GetFullPath(json_path); 
            return absolutePath;
        }

        


    }
}
