using System;
using System.Data.OleDb;

namespace uvsWinFormTask.DB
{
    class DBcontroller
    {
        public OleDbConnection MyCon { get; set; }
        //Method to insert a row.
        public void DBInsert(string id, DateTime Time, string data)
        {
            //Create connection obj and add dynamic .mdb file location
            OleDbConnection conn;
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\..\\..\\DB\\Threads.mdb";
            conn = new OleDbConnection(@"Provider=Microsoft.JET.OLEDB.4.0;Data Source="+path);

            //Open DB, add insert command, execute insert command, close DB.
            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO Thread([ThreadId], [Time],  [Data])VALUES('" + id + "', '" + Time + "','" + data + "')";
            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}
