using FASILKOMPOINT.App.Core;
using FASILKOMPOINT.App.Models;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASILKOMPOINT.App.Context
{
    internal class KomentarContext : DatabaseWrapper
    {
        private static string table = "komentar";

        public void addKomentar(M_Komentar komentarBaru)
        {
            string query = $"INSERT INTO komentar(id_komentar, komentar, aktivitas_id_aktivitas, tim_skpi_username) SELECT COALESCE(MAX(id_komentar),0)+10, @komentar, @aktivitas_id_aktivitas, @tim_skpi_username FROM komentar;";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@komentar", NpgsqlDbType.Text){Value = komentarBaru.komentar},
                new NpgsqlParameter("@aktivitas_id_aktivitas", NpgsqlDbType.Integer){Value = komentarBaru.aktivitas_id_aktivitas},
                new NpgsqlParameter("@tim_skpi_username", NpgsqlDbType.Varchar){Value = komentarBaru.tim_skpi_username}
            };
            commandExecutor(query, parameters);
        }
    }
}
