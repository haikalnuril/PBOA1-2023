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
            string query = $"SELECT mahasiswa.nama AS Nama, {table}.mahasiswa_username AS NIM, prodi.nama_prodi AS Prodi, SUM(poin.poin) AS Poin FROM {table} JOIN mahasiswa ON mahasiswa.username = {table}.mahasiswa_username JOIN prodi ON mahasiswa.prodi_id_prodi = prodi.id_prodi JOIN poin ON {table}.poin_id_poin = poin.id_poin WHERE {table}.is_acc = 'disetujui' GROUP BY {table}.mahasiswa_username, mahasiswa.nama, prodi.nama_prodi;";
            DataTable dataMahasiswa = queryExecutor(query);
            return dataMahasiswa;
        }
        public static DataTable showSearchDataSKPIMahasiswa(string nama)
        {
            string query = $"SELECT mahasiswa.nama AS Nama, {table}.mahasiswa_username AS NIM, prodi.nama_prodi AS Prodi, SUM(poin.poin) AS Poin FROM {table} JOIN mahasiswa ON mahasiswa.username = {table}.mahasiswa_username JOIN prodi ON mahasiswa.prodi_id_prodi = prodi.id_prodi JOIN poin ON {table}.poin_id_poin = poin.id_poin WHERE mahasiswa.nama ILIKE '%'||@nama||'%' AND {table}.is_acc = 'disetujui' GROUP BY {table}.mahasiswa_username, mahasiswa.nama, prodi.nama_prodi;";
            NpgsqlParameter[] parameters = 
            {
                new NpgsqlParameter("@nama", NpgsqlDbType.Varchar){Value = nama},
            };
            DataTable dataMahasiswa = queryExecutor(query, parameters);
            return dataMahasiswa;
        }
        public static DataTable showValidasiSKPI()
        {
            string query = $"SELECT mahasiswa.nama AS Nama_Mahasiswa, {table}.mahasiswa_username AS NIM, prodi.nama_prodi AS Prodi FROM {table} JOIN mahasiswa ON mahasiswa.username = {table}.mahasiswa_username JOIN prodi ON mahasiswa.prodi_id_prodi = prodi.id_prodi WHERE is_acc = 'menunggu'";
            DataTable dataMahasiswa = queryExecutor(query);
            return dataMahasiswa;
        }
        public static DataTable showDetailSKPI(string username)
        {
            string query = $"";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = username}
            };  
            DataTable dataMahasiswa = queryExecutor(query, parameters);
            return dataMahasiswa;
        }
    }
}