using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GNE
{
    public abstract class MySQL
    {
        private string BD;
        private string Serv;
        private MySqlConnection con;
        private string Pass;
        private MySqlDataReader rs;
        private MySqlCommand st;
        private string User;


        protected MySQL(string bd,string serv,string user,string pass)
        {
            this.BD = bd;
            this.Serv = serv;
            this.User = user;
            this.Pass = pass;
        }

        public List<Dictionary<string, string>> Get()
        {
            throw new System.NotImplementedException();
        }

        public int Up()
        {
            throw new System.NotImplementedException();
        }
    }
}