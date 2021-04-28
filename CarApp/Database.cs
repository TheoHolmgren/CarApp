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

        //Om dbConn inte är stängd så stäng dbConn

        public void CloseConnection()
        {
            if (dbConn.State != System.Data.ConnectionState.Closed)
            {
                dbConn.Close();
            }
        }

        public int AddCarRow(Car car)
        {
            string qInsert = "INSERT INTO car ('regNr','make','model','year','forSale') VALUES (@regNr, @make, @model, @year, @forSale);";

            SQLiteCommand dbCommand = new SQLiteCommand(qInsert, dbConn);
            OpenConnection();

            //koppla parametrar
            dbCommand.Parameters.AddWithValue(@"regNr", car.GetRegNr());
            dbCommand.Parameters.AddWithValue(@"make", car.GetMake());
            dbCommand.Parameters.AddWithValue(@"model", car.GetModel());
            dbCommand.Parameters.AddWithValue(@"year", car.GetYear());

            dbCommand.Parameters.AddWithValue(@"forSale", (car.GetForSale() ? 1 : 0));

            //Svaret är hur många rader som påverkas av "frågan" jag ställer (Skulle kunna vara flera om det är flera som läggs till eller tas bort)
            int result = dbCommand.ExecuteNonQuery();
            CloseConnection();
            return result;
        }


    }
}
