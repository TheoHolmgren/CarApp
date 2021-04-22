using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CarApp
{
    class Database
    {
        public SQLiteConnection dbConn; //Håller i connection
        private string databaseFilename = "./car.db"; //Sökväg till databsen (roten)

        public Database()
        {
            //Skapa databasfilen om den inte finns
            if (!File.Exists(databaseFilename))
            {
                File.Create(databaseFilename);
            }

            //Skapa dbcomm
            dbConn = new SQLiteConnection("Data source=" + databaseFilename); //En connection-sträng innehållande hur den ska koppla upp sig.

        }

        //Öppna och stänga en koppling till databasen

        //Om dbConn inte är öppen så öppna dbConn

        public void OpenConnection()
        {
            if(dbConn.State != System.Data.ConnectionState.Open)
            {
                dbConn.Open();
            }

        }


    }
}
