using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics; //Using This Library To Start a Process

namespace Game_Launcher
{
    class launcher
    {
        public static void PlayGame()
        {
            Process.Start("Dungeon Drag.exe"); //This Will Launch The Game.exe File
            //Environment.Exit(0); //This will terminate the laucnher and will make sure no backbround processes are running
        }
    }
}
