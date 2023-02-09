﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConsulta.Tools
{
    public class Connectdb
    {
        public object JsonConvert { get; private set; }

       public string StringConnect()
        {
            string mySqlConnStr = string.Empty;
            try
            {
                string oJsonConfig = System.IO.File.ReadAllText(@"appsettings.json");
                StruConfig oStrincConnect = JsonConvert.DeserializeObject<StruConfig>(oJsonConfig);
          
                mySqlConnStr = $"Data Source={oStrincConnect.ConnectionStrings.MYSQL_DBHOST};" +
                    $" Initial Catalog={oStrincConnect.ConnectionStrings.MYSQL_DATABASE};" +
                    $"User ID={oStrincConnect.ConnectionStrings.MYSQL_USER};" +
                    $"Password={oStrincConnect.ConnectionStrings.MYSQL_PASSWORD}";
            }
            catch (Exception)
            {
                throw;
            }
            return mySqlConnStr;
        }
    }
}
