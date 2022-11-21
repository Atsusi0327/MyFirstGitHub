using Npgsql;
using System.Text;
using DoubleCraneLineBot.Models;
using Dapper;

namespace DoubleCraneLineBot.DataAccess
{
    public class LineBotDA
    {
        public List<BotListModel> GetBotList()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=192.168.56.5;Port=5432;Database=DoubleCraneLineBot;User Id=postgres;Password=Postgres@9487"))
            {
                Console.WriteLine("Run LibeBotDA.GetBotList() Success.");
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT * FROM BotList;");
                return conn.Query<BotListModel>(sb.ToString()).ToList();
            }
        }
    }
}
