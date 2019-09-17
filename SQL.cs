using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GSB
{
    class SQL
    {
        private string IP = "172.19.0.3";
        private string USER = "root";
        private string PASSWORD = "0550002D";
        private string DATABASE = "officine_project";
        private MySqlConnection connexion;

        public SQL()
        {
            string laRequete = "server=" + this.IP + ";user=" + this.USER + ";database=" + this.DATABASE + ";port=3306;password=" + this.PASSWORD;
            connexion = new MySqlConnection(laRequete);
        }
        public MySqlConnection GetCo()
        {
            return connexion;
        }

        public string getArticles()
        {
            return "server=" + this.IP + ";user=" + this.USER + ";database=" + this.DATABASE + ";port=3306;password=" + this.PASSWORD;
        }


    }
}
