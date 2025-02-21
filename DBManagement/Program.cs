using Microsoft.VisualBasic;
using System;
using System.Data.SqlClient;

namespace DBManagement
{
    internal class DBManagement
    {
        static void Main(string[] args)
        {
            DataManipulationCommands conn = new DataManipulationCommands();
            //connection.InsertData("sam", "sam@gmail.com", 23);
            //conn.InsertData("adi", "mail.com", 34);
            //Console.WriteLine(conn.IDExist(3));
            //conn.DeleteData(3);
            //conn.GetLastid();
            //conn.GetAllData();
            //conn.UpdateData();
            int[] ints = new int[2];
            var l = ints.Take(2);
            char defaultChar = default(char);
            string s = default(string);
            //foreach (var item in l)
            //{
            //    Console.WriteLine(item);
            //}
            //char c = ch;
            
        }
    }
    interface i
    {
        static void m()
        {
            Console.WriteLine("i");
        }
        void j();
    }


}