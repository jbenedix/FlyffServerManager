using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FlyffServerManager
{
    public static class ConfigManager
    {
        public static config config { get; set; }

        public static void LoadData()
        {
            config = new config();
            LoadConfigFile();
        }

        static void LoadConfigFile()
        {
            var configData = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\config.ini");

            //Go Thorugh each line and check config
            foreach (var line in configData) 
            {
                //Dont check Comments
                if (!line.StartsWith("#"))
                {
                    // I prefer if/else if over switch/case
                    if (line.Split('=').First() == "account")
                    {
                        config.account = line.Split("=").Last();
                    }
                    else if (line.Split('=').First() == "certifier")
                    {
                        config.certifier = line.Split("=").Last();
                    }
                    else if (line.Split('=').First() == "database")
                    {
                        config.database = line.Split("=").Last();
                    }
                    else if (line.Split('=').First() == "core")
                    {
                        config.core = line.Split("=").Last();
                    }
                    else if (line.Split('=').First() == "login")
                    {
                        config.login = line.Split("=").Last();
                    }
                    else if (line.Split('=').First() == "cache")
                    {
                        config.cache = line.Split("=").Last();
                    }
                    else if (line.Split('=').First() == "world")
                    {
                        config.world = line.Split("=").Last();
                    }
                    else if (line.Split('=').First() == "client")
                    {
                        config.client = line.Split("=").Last();
                    }
                }
            }
        }
    }
}
