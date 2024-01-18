using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apteka
{
    internal class SQLClass
    {
        public const string CONNECTION_STRING =
         "SslMode=none;Server=localhost;Database=apteka;port=3306;Uid=root;charset=utf8";

        public static MySqlConnection CON;
        //Функция Select-запроса
        public static List<string> myselect(string cmdText)
        {
            List<string> list = new List<string>();
            MySqlCommand cmd = new MySqlCommand(cmdText, CON);
            DbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    list.Add(reader.GetString(i).ToString());
                }

            }
            reader.Close();
            return list;

        }

        //Функция Insert-запроса
        public static void myUpdate(string cmdText)
        {
            MySqlCommand cmd = new MySqlCommand(cmdText, CON);
            DbDataReader reader = cmd.ExecuteReader();
            reader.Close();

        }
    }
}
