using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GNE
{
    public class DAO : MySQL
    {
        public string[] param_co;
        private string Table;

        public DAO(string bd, string serv, string user, string pass):base (bd,serv,user,pass)
        {
            
        }

        public List<Dictionary<string, string>> select()
        {
            throw new System.NotImplementedException();
        }

        public int Update()
        {
            throw new System.NotImplementedException();
        }
    }
}