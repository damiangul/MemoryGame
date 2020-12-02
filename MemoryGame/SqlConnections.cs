using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    class SqlConnections
    {
        SqlConnection cnn; //nawiązywanie połączenia
        SqlCommand command; //realizowanie instrukcji
        SqlDataReader dataReader; //Do czytania danych
        SqlDataAdapter adapter = new SqlDataAdapter(); //Do insertowania danych
        string sql;
        string connectionString;
        int position = 1;

        public SqlConnections()
        {
            connectionString = "Data Source=.;Initial Catalog=memorygame;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
        }
        public void insertData(string gamerNickname, string gamerScore, string gamerResult)
        {
            sql = "insert into Score(nickname, winTime, result) values ('" + gamerNickname + "', '" + gamerScore + "', '" + gamerResult + "')";
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
        }

        public int getPosition(string gamerNickname, string gamerScore, string gamerResult)
        {
            sql = "select * from Score order by result desc, winTime asc";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {

                if (dataReader.GetValue(1).ToString() == gamerNickname && dataReader.GetValue(2).ToString() == gamerScore && dataReader.GetValue(3).ToString() == gamerResult)
                    break;
                else
                    position++;
            }

            dataReader.Close();
            return position;
        }

        public void displayTop(TextBox textbox)
        {
            int i = 0;
            sql = "select TOP 5 nickname, winTime, result from Score order by result desc, winTime asc";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            string topPlayers = "";

            while (dataReader.Read())
            {
                topPlayers = topPlayers + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "s - " + dataReader.GetValue(2) + "\r\n\r\n";
            }

            textbox.Text = topPlayers;
            dataReader.Close();
        }

        public void closeConnections()
        {
            command.Dispose();
            cnn.Close();
        }
    }
}
