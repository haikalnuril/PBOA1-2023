using FASILKOMPOINT.App.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASILKOMPOINT.App.Context
{
    internal class SubbutirContext : DatabaseWrapper
    {
        private static string table = "subbutir";
        public static DataTable showPrestasi3Subbutir()
        {
            string query = $"SELECT * FROM {table} WHERE id_subbutir = 301 OR id_subbutir BETWEEN 303 AND 304";
            DataTable dataSubbutir = queryExecutor(query);
            return dataSubbutir;
        }
        public static DataTable showPrestasi4Subbutir()
        {
            string query = $"SELECT * FROM {table} WHERE id_subbutir BETWEEN 301 AND 304";
            DataTable dataSubbutir = queryExecutor(query);
            return dataSubbutir;
        }
        //public static DataTable showPrestasi0Subbutir()
        //{
                //yang null itu
        //}
    }
}
