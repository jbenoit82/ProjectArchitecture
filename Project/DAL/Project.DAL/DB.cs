using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.DAL
{
    public partial class DB
    {
        private static readonly DB _instance = new DB();

        public static DB Instance => _instance;

        #region constructeurs
        public DB()
        {

        }
        #endregion
    }
}
