using FASILKOMPOINT.App.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASILKOMPOINT.App.Context
{
    internal class ButirContext : DatabaseWrapper
    {
        private static string table = "butir";
        public static DataTable showTingkatPrestasi()
        {
            string query = $"SELECT * FROM {table} WHERE id_butir BETWEEN 501 AND 514";
            DataTable dataButir = queryExecutor(query);
            return dataButir;
        }
        public static DataTable showTingkatKeikutsertaan()
        {
            string query = $"SELECT * FROM {table} WHERE id_butir = 501 OR id_butir BETWEEN 504 AND 507 OR id_butir BETWEEN 515 AND 522";
            DataTable dataButir = queryExecutor(query);
            return dataButir;
        }
        public static DataTable showTingkatSertifikasi()
        {
            string query = $"SELECT * FROM {table} WHERE id_butir BETWEEN 523 AND 524";
            DataTable dataButir = queryExecutor(query);
            return dataButir;

        }
    }
}
