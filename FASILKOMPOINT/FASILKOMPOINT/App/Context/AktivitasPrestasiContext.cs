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

namespace FASILKOMPOINT.App.Context
{
    internal class AktivitasPrestasiContext : DatabaseWrapper
    {
        private static string table = "aktivitas";

        public static DataTable showPrestasi(string username, int kategori)
        {
            string query = $"SELECT ROW_NUMBER() OVER (ORDER BY {table}.tanggal) as No, {table}.nama_prestasi as Nama, CONCAT ('Tanggal: ', {table}.tanggal, '\r\n', 'Juara: ', {table}.juara, '\r\n', 'Tingkat: ', {table}.level_tingkat, '\r\n', 'Nama Dosen Pembimbing: ', {table}.nama_dosbing,'\r\n', 'No. Surat Tugas: ', {table}.no_surat) AS Keterangan, {table}.url_penyelenggara AS Penyelenggara, {table}.file_bukti AS Bukti, poin.poin as Poin FROM {table} JOIN poin ON poin.id_poin = {table}.poin_id_poin WHERE {table}.mahasiswa_username = @username AND {table}.kategori_id_kategori = @kategori AND ({table}.is_acc = 'menunggu' or {table}.is_acc = 'ditolak')";
            ///string query = $"SELECT {table}.nama_prestasi as Prestasi, {table}.tanggal as Tanggal, {table}.url_penyelenggara as Penyelenggara, {table}.juara as Juara, {table}.file_bukti as Bukti, {table}.jenis_kepesertaan as Kepesertaan, {table}.level_tingkat as Tingkat, poin.poin as Poin FROM {table} JOIN poin ON poin.id_poin = {table}.poin_id_poin WHERE {table}.mahasiswa_username = @username AND {table}.kategori_id_kategori = @kategori AND ({table}.is_acc = 'menunggu' or {table}.is_acc = 'ditolak');";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@kategori", NpgsqlDbType.Integer){Value = kategori},
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = username},
            };
            DataTable dataAktivitas = queryExecutor(query, parameters);
            return dataAktivitas;
        }
        public static void addPrestasi(M_Aktivitas_Prestasi aktivitasPrestasiBaru)
        {
            string query = $"INSERT INTO {table}(id_aktivitas, nama_prestasi, tanggal, url_penyelenggara, juara, file_bukti, jenis_kepesertaan, level_tingkat, poin_id_poin, mahasiswa_username, is_acc, nama_dosbing, no_surat, kategori_id_kategori) SELECT COALESCE(MAX(id_aktivitas), 0) + 1, @nama_prestasi, @tanggal, @url_penyelenggara, @juara, @file_bukti, @jenis_kepesertaan, @level_tingkat, (SELECT id_poin FROM poin WHERE butir_id_butir = (SELECT id_butir FROM butir WHERE nama_butir = @level_tingkat) AND subbutir_id_subbutir = (SELECT id_subbutir from subbutir WHERE nama_butir = @juara) AND kategori_id_kategori = @kategori), @mahasiswa_username, @is_acc, @nama_dosbing, @no_surat, @kategori FROM {table};";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@kategori", NpgsqlDbType.Integer){Value = aktivitasPrestasiBaru.kategori_id_kategori},
                new NpgsqlParameter("@nama_prestasi", NpgsqlDbType.Varchar){Value = aktivitasPrestasiBaru.nama_prestasi},
                new NpgsqlParameter("@tanggal", NpgsqlDbType.Date){Value = aktivitasPrestasiBaru.tanggal},
                new NpgsqlParameter("@url_penyelenggara", NpgsqlDbType.Varchar){Value = aktivitasPrestasiBaru.url_penyelenggara},
                new NpgsqlParameter("@juara", NpgsqlDbType.Varchar){Value = aktivitasPrestasiBaru.juara},
                new NpgsqlParameter("@file_bukti", NpgsqlDbType.Varchar){Value = aktivitasPrestasiBaru.file_bukti},
                new NpgsqlParameter("@jenis_kepesertaan", NpgsqlDbType.Varchar){Value = aktivitasPrestasiBaru.jenis_kepesertaan},
                new NpgsqlParameter("@level_tingkat", NpgsqlDbType.Varchar){Value = aktivitasPrestasiBaru.level_tingkat},
                new NpgsqlParameter("@mahasiswa_username", NpgsqlDbType.Varchar){Value = aktivitasPrestasiBaru.mahasiswa_username},
                new NpgsqlParameter("@nama_dosbing", NpgsqlDbType.Varchar){Value = aktivitasPrestasiBaru.nama_dosbing},
                new NpgsqlParameter("@no_surat", NpgsqlDbType.Varchar){Value = aktivitasPrestasiBaru.no_surat},
                new NpgsqlParameter("@is_acc", NpgsqlDbType.Varchar){Value = aktivitasPrestasiBaru.is_acc}
            };
            commandExecutor(query, parameters);
        }
        public static void updatePrestasi(M_Aktivitas_Prestasi aktivitasPrestasiEdit)
        {
            string query = $"UPDATE {table} SET nama_prestasi = @nama_prestasi, tanggal = @tanggal, url_penyelanggara = @url_penyelenggara, juara = @juara, file_bukti = @file_bukti, jenis_kepesertaan = @jenis_kepesertaan, level_tingkat = @level_tingkat, poin_id_poin = (SELECT id_poin FROM poin WHERE butir_id_butir = (SELECT id_butir FROM butir WHERE nama_butir = @level_tingkat) AND subbutir_id_subbutir = (SELECT id_subbutir FROM subbutir WHERE nama_subbutir = @jenis_kepesertaan) AND kategori_id_kategori = @kategori), is_acc = @is_acc WHERE id_aktivitas = @id_aktivitas";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_prestasi", NpgsqlDbType.Varchar){Value = aktivitasPrestasiEdit.nama_prestasi},
                new NpgsqlParameter("@tanggal", NpgsqlDbType.Date){Value = aktivitasPrestasiEdit.tanggal},
                new NpgsqlParameter("@url_penyelenggara", NpgsqlDbType.Varchar){Value = aktivitasPrestasiEdit.url_penyelenggara},
                new NpgsqlParameter("@juara", NpgsqlDbType.Varchar){Value = aktivitasPrestasiEdit.juara},
                new NpgsqlParameter("@file_bukti", NpgsqlDbType.Varchar){Value = aktivitasPrestasiEdit.file_bukti},
                new NpgsqlParameter("@jenis_kepesertaan", NpgsqlDbType.Varchar){Value = aktivitasPrestasiEdit.jenis_kepesertaan},
                new NpgsqlParameter("@level_tingkat", NpgsqlDbType.Varchar){Value = aktivitasPrestasiEdit.level_tingkat},
                new NpgsqlParameter("@is_acc", NpgsqlDbType.Varchar){Value = aktivitasPrestasiEdit.is_acc},
                new NpgsqlParameter("@id_aktivitas", NpgsqlDbType.Integer){Value = aktivitasPrestasiEdit.id_aktivitas}
            };
            commandExecutor(query, parameters);
        }
        public DataTable showRekapPrestasi(string username, int kategori)
        {
            string query = $"SELECT {table}.nama_prestasi as Prestasi, {table}.tanggal as Tanggal, {table}.url_penyelenggara as Penyelenggara, {table}.juara as Juara, {table}.file_bukti as Bukti, {table}.jenis_kepesertaan as Kepesertaan, {table}.level_tingkat as Tingkat, poin.poin as Poin FROM {table} JOIN poin ON poin.id_poin = {table}.poin_id_poin WHERE {table}.mahasiswa_username = @username AND {table}.kategori_id_kategori = @kategori AND {table}.is_acc = 'disetujui';";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@kategori", NpgsqlDbType.Integer){Value = kategori},
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = username},
            };
            DataTable dataAktivitas = queryExecutor(query, parameters);
            return dataAktivitas;
        }
    }
}