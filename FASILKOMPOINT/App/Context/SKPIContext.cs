using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FASILKOMPOINT.App.Core;
using Npgsql;
using NpgsqlTypes;

namespace FASILKOMPOINT.App.Context
{
    internal class SKPIContext : DatabaseWrapper
    {
        private static string table = "aktivitas";

        public static DataTable namaSKPI(string username)
        {
            string query = $"SELECT mahasiswa.nama AS nama_mahasiswa FROM aktivitas JOIN mahasiswa ON aktivitas.mahasiswa_username = @username;";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = username},
            };
            DataTable dataSKPI = queryExecutor(query, parameters);
            return dataSKPI;
        }
        public static DataTable NIMSKPI(string username)
        {
            string query = $"SELECT DISTINCT mahasiswa_username AS username FROM aktivitas WHERE mahasiswa_username = @username;";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = username},
            };
            DataTable dataSKPI = queryExecutor(query, parameters);
            return dataSKPI;
        }
        public static DataTable namaKegiatan(string username)
        {
            string query = $"SELECT nama_kegiatan FROM aktivitas WHERE kategori_id_kategori = 601 AND mahasiswa_username = @username;";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = username},
            };
            DataTable dataSKPI = queryExecutor(query, parameters);
            return dataSKPI;
        }
        public static DataTable namaPrestasi(string username)
        {
            string query = $"SELECT nama_kegiatan FROM aktivitas WHERE kategori_id_kategori = 602 AND mahasiswa_username = @username;";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = username},
            };
            DataTable dataSKPI = queryExecutor(query, parameters);
            return dataSKPI;
        }
        public static DataTable namaSertifikasi(string username)
        {
            string query = $"SELECT nama_kegiatan FROM aktivitas WHERE kategori_id_kategori = 603 AND mahasiswa_username = @username;";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = username},
            };
            DataTable dataSKPI = queryExecutor(query, parameters);
            return dataSKPI;
        }
    }
}
