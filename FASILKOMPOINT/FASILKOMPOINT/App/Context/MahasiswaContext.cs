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
        public static DataTable showDetailValidasiSKPI(string username)
        {
            {
                string query = $"SELECT {table}.id_aktivitas, {table}.nama_kegiatan as Nama, CONCAT('Tanggal: ', {table}.tanggal, '\r\n', 'Tingkat: ', {table}.level_tingkat, '\r\n', 'Jenis: ', {table}.jenis_kepesertaan,'\r\n', 'Bukti: ',{table}.file_bukti )  as Keterangan,{table}.is_acc as Status, komentar.komentar as Komentar, poin.poin as Poin FROM {table} JOIN poin ON poin.id_poin = {table}.poin_id_poin JOIN komentar ON komentar.aktivitas_id_aktivitas = {table}.id_aktivitas WHERE {table}.mahasiswa_username = @username AND {table}.kategori_id_kategori = 601 AND {table}.is_acc = 'menunggu'" +
                    $"UNION SELECT {table}.id_aktivitas, {table}.nama_prestasi as Nama, CONCAT ('Tanggal: ', {table}.tanggal, '\r\n', 'Juara: ', {table}.juara, '\r\n', 'Tingkat: ', {table}.level_tingkat, '\r\n','Url Penyelenggara: ', {table}.url_penyelenggara, '\r\n', 'Bukti: ', {table}.file_bukti, '\r\n', 'Nama Dosen Pembimbing: ', {table}.nama_dosbing,'\r\n', 'No. Surat Tugas: ', {table}.no_surat) AS Keterangan, {table}.is_acc as Status, komentar.komentar as Komentar, poin.poin as Poin FROM {table} JOIN poin ON poin.id_poin = {table}.poin_id_poin JOIN komentar ON komentar.aktivitas_id_aktivitas = {table}.id_aktivitas WHERE {table}.mahasiswa_username = @username AND {table}.kategori_id_kategori = 602 AND {table}.is_acc = 'menunggu'" +
                    $"UNION SELECT {table}.id_aktivitas, {table}.judul_sertifikasi as Nama,CONCAT ('Tanggal: ', {table}.tanggal, '\r\n', 'Tingkat Penyelenggara: ', {table}.tingkat_penyelenggara, '\r\n', 'Nama Penyelenggara: ', {table}.nama_penyelenggara,'\r\n', 'Bukti: ', {table}.file_bukti) as Keterangan,  {table}.is_acc as Status, komentar.komentar as Komentar, poin.poin as Poin FROM {table} JOIN poin ON poin.id_poin = {table}.poin_id_poin JOIN komentar ON komentar.aktivitas_id_aktivitas = {table}.id_aktivitas WHERE {table}.mahasiswa_username = @username AND {table}.kategori_id_kategori = 603 AND {table}.is_acc = 'menunggu';";
                NpgsqlParameter[] parameters =
                {
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = username},
                //new NpgsqlParameter("@nim", NpgsqlDbType.Varchar){Value = nim}
                };
                DataTable dataMahasiswa = queryExecutor(query, parameters);
                return dataMahasiswa;
            }
        }
        public static void updateStatustoDisetujui(int id_aktivitas)
        {
            string query = $"UPDATE {table} SET is_acc = 'disetujui' WHERE id_aktivitas = @id_aktivitas;";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_aktivitas", NpgsqlDbType.Integer){Value = id_aktivitas}
            };
            commandExecutor(query, parameters);
        }

        public static void updateStatustoDitolak(int id_aktivitas)
        {
            string query = $"UPDATE {table} SET is_acc = 'ditolak' WHERE id_aktivitas = @id_aktivitas;";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_aktivitas", NpgsqlDbType.Integer){Value = id_aktivitas}
            };
            commandExecutor(query, parameters);
        }
        public static void updateKomentarDitolak(int id_aktivitas, string komentar)
        { 
            string query = $"UPDATE komentar SET komentar = @komentar WHERE aktivitas_id_aktivitas = @id_aktivitas;";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_aktivitas", NpgsqlDbType.Integer){Value = id_aktivitas},
                new NpgsqlParameter("@komentar", NpgsqlDbType.Text){Value = komentar}
            };
            ///MessageBox.Show($"Parameter 1: {id_aktivitas}");
            ///MessageBox.Show($"Parameter 2: {komentar}");
            commandExecutor(query, parameters);
        }
    }
}