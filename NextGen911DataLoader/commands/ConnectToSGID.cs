﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcGIS.Core.Data;

namespace NextGen911DataLoader.commands
{
    class ConnectToSGID
    {
        public static DatabaseConnectionProperties Execute()
        {
            try
            {
                DatabaseConnectionProperties sgidConnectionProperties = new DatabaseConnectionProperties(ArcGIS.Core.Data.EnterpriseDatabaseType.SQLServer)
                {
                    AuthenticationMode = ArcGIS.Core.Data.AuthenticationMode.DBMS,
                    Instance = "sgid.agrc.utah.gov",
                    Database = "SGID10",
                    User = "agrc",
                    Password = "agrc",
                    Version = "sde.DEFAULT"
                };

                return sgidConnectionProperties;
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an error with ConnectToSGID method." +
                    ex.Message + " " + ex.Source + " " + ex.InnerException + " " + ex.HResult + " " + ex.StackTrace + " " + ex);

                return null;
            }
        }
    }
}
