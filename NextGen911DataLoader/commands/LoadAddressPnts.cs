﻿using ArcGIS.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextGen911DataLoader.commands
{
    class LoadAddressPnts
    {
        public static void Execute(DatabaseConnectionProperties sgidConnectionProperties, string fgdbPath)
        {
            try
            {


            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an error with LoadAddressPnts method." +
                ex.Message + " " + ex.Source + " " + ex.InnerException + " " + ex.HResult + " " + ex.StackTrace + " " + ex);
            }
        }
    }
}
