using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
