using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FASILKOMPOINT.App.Core;
using FASILKOMPOINT.App.Models;
using NpgsqlTypes;
using System.Collections;
///using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Drawing.Text;

namespace FASILKOMPOINT.App.Context
{
    internal class MahasiswaContext : DatabaseWrapper
    {
        private static string table = "aktivitas";

        public static DataTable showDataSKPIMahasiswa()
        {
            string query = $"SELECT ROW_NUMBER() OVER (ORDER BY {table}.mahasiswa_username) AS No, mahasiswa.nama AS Nama, {table}.mahasiswa_username AS NIM, prodi.nama_prodi AS Prodi, SUM(poin.poin) AS Poin FROM {table} JOIN mahasiswa ON mahasiswa.username = {table}.mahasiswa_username JOIN prodi ON mahasiswa.prodi_id_prodi = prodi.id_prodi JOIN poin ON {table}.poin_id_poin = poin.id_poin GROUP BY {table}.mahasiswa_username, mahasiswa.nama, prodi.nama_prodi;";
            //string query = $"SELECT mahasiswa.nama AS Nama, {table}.mahasiswa_username AS NIM, prodi.nama_prodi AS Prodi, SUM(poin.poin) AS Poin FROM {table} JOIN mahasiswa ON mahasiswa.username = {table}.mahasiswa_username JOIN prodi ON mahasiswa.prodi_id_prodi = prodi.id_prodi JOIN poin ON {table}.poin_id_poin = poin.id_poin GROUP BY {table}.mahasiswa_username, mahasiswa.nama, prodi.nama_prodi;";
            DataTable dataMahasiswa = queryExecutor(query);
            return dataMahasiswa;
        }
        public static DataTable showSearchDataSKPIMahasiswa(string nim)
        {
            string query = $"SELECT ROW_NUMBER() OVER (ORDER BY {table}.mahasiswa_username) AS No, mahasiswa.nama AS Nama, {table}.mahasiswa_username AS NIM, prodi.nama_prodi AS Prodi, SUM(poin.poin) AS Poin FROM {table} JOIN mahasiswa ON mahasiswa.username = {table}.mahasiswa_username JOIN prodi ON mahasiswa.prodi_id_prodi = prodi.id_prodi JOIN poin ON {table}.poin_id_poin = poin.id_poin WHERE mahasiswa.username ILIKE '%'||@nim||'%' GROUP BY {table}.mahasiswa_username, mahasiswa.nama, prodi.nama_prodi;";
            NpgsqlParameter[] parameters = 
            {
                new NpgsqlParameter("@nim", NpgsqlDbType.Varchar){Value = nim},
            };
            DataTable dataMahasiswa = queryExecutor(query, parameters);
            return dataMahasiswa;
        }
        public static DataTable showValidasiSKPI()
        {
            string query = $"SELECT ROW_NUMBER() OVER (ORDER BY {table}.mahasiswa_username) AS No, id_aktivitas AS id_aktivitas, mahasiswa.nama AS Nama_Mahasiswa, {table}.mahasiswa_username AS NIM, prodi.nama_prodi AS Prodi FROM {table} JOIN mahasiswa ON mahasiswa.username = {table}.mahasiswa_username JOIN prodi ON mahasiswa.prodi_id_prodi = prodi.id_prodi WHERE is_acc = 'menunggu'";
            DataTable dataMahasiswa = queryExecutor(query);
            return dataMahasiswa;
        }
        public static int CekKategori(string id_aktivitas)
        {
            string query = $"SELECT {table}.kategori_id_kategori FROM {table} WHERE id_aktivitas = @id_aktivitas";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_aktivitas", NpgsqlDbType.Varchar){Value = id_aktivitas}

            };
            return commandExecutorIntValue(query, parameters);
        }
        public static DataTable showDetailValidasiSKPI(int id_aktivitas, int kategori)
        {
            if (kategori == 601)
            {
                string query = $"";
                NpgsqlParameter[] parameters =
                {
                //new NpgsqlParameter("@nim", NpgsqlDbType.Varchar){Value = nim}
                };
                DataTable dataMahasiswa = queryExecutor(query, parameters);
                return dataMahasiswa;
            }
            else if (kategori == 602)
            {
                string query = $"";
                NpgsqlParameter[] parameters =
                {
                //new NpgsqlParameter("@nim", NpgsqlDbType.Varchar){Value = nim}
                };
                DataTable dataMahasiswa = queryExecutor(query, parameters);
                return dataMahasiswa;
            }
            else
            {
                string query = $"SELECT ROW_NUMBER() OVER (ORDER BY {table}.mahasiswa_username) AS No, CONCAT('Tanggal: ', aktivitas.tanggal, '\r\n', 'Tingkat: ', aktivitas.level_tingkat, '\r\n', 'Jenis: ', aktivitas.jenis_kepesertaan)";
                NpgsqlParameter[] parameters =
                {
                //new NpgsqlParameter("@nim", NpgsqlDbType.Varchar){Value = nim}
                };
                DataTable dataMahasiswa = queryExecutor(query, parameters);
                return dataMahasiswa;
            }
        }
    }
}