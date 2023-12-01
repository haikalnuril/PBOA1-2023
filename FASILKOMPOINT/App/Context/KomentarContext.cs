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

        public void updateKomentar(M_Komentar komentarEdit)
        {
            string query = $"UPDATE {table} SET komentar = @komentar, aktivitas_id_aktivitas = @aktivitas_id_aktivitas, tim_skpi_userame = @tim_skpi_username WHERE aktivitas_id_aktivitas = aktivitas.id_aktivitas;";
                ///$"INSERT INTO komentar(id_komentar, komentar, aktivitas_id_aktivitas, tim_skpi_username) SELECT COALESCE(MAX(id_komentar),0)+10, @komentar, @aktivitas_id_aktivitas, @tim_skpi_username FROM komentar;";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@komentar", NpgsqlDbType.Text){Value = komentarEdit.komentar},
                new NpgsqlParameter("@aktivitas_id_aktivitas", NpgsqlDbType.Integer){Value = komentarEdit.aktivitas_id_aktivitas},
                new NpgsqlParameter("@tim_skpi_username", NpgsqlDbType.Varchar){Value = komentarEdit.tim_skpi_username}
            };
            commandExecutor(query, parameters);
        }
    }
}
