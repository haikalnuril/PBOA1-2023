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
    internal class AktivitasKeikutsertaanContext : DatabaseWrapper
    {
        private readonly static string table = "aktivitas";

        public static DataTable showKeikutsertaan(string username, int kategori)
        {
            string query = $"SELECT {table}.nama_kegiatan as Kegiatan, {table}.tanggal as Tanggal, {table}.file_bukti as Bukti, {table}.jenis_kepesertaan as Kepesertaan, {table}.level_tingkat as Tingkat, poin.poin as Poin FROM {table} JOIN poin ON poin.id_poin = {table}.poin_id_poin WHERE {table}.mahasiswa_username = @username AND {table}.kategori_id_kategori = @kategori AND ({table}.is_acc = 'menunggu' or {table}.is_acc = 'ditolak');";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@kategori", NpgsqlDbType.Integer){Value = kategori},
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = username},
            };
            DataTable dataAktivitas = queryExecutor(query, parameters);
            return dataAktivitas;
        }
        public static void addKeikutsertaan(M_Aktivitas_Keikutsertaan aktivitasKeikutsertaanBaru)
        {
            string query = $"INSERT INTO {table}(id_aktivitas, nama_kegiatan, tanggal, file_bukti, jenis_kepesertaan, level_tingkat, poin_id_poin, mahasiswa_username, is_acc, kategori_id_kategori) SELECT COALESCE(MAX(id_aktivitas), 0) + 1, @nama_kegiatan, @tanggal, @file_bukti, @jenis_kepesertaan, @level_tingkat, (SELECT id_poin FROM poin WHERE butir_id_butir = (SELECT id_butir FROM butir WHERE nama_butir = @level_tingkat) AND subbutir_id_subbutir = (SELECT id_subbutir FROM subbutir WHERE nama_subbutir = @jenis_kepesertaan) AND kategori_id_kategori = @kategori), @mahasiswa_username, @is_acc, @kategori FROM {table};";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_kegiatan", NpgsqlDbType.Varchar){Value = aktivitasKeikutsertaanBaru.nama_kegiatan},
                new NpgsqlParameter("@tanggal", NpgsqlDbType.Date){Value = aktivitasKeikutsertaanBaru.tanggal},
                new NpgsqlParameter("@file_bukti", NpgsqlDbType.Varchar){Value = aktivitasKeikutsertaanBaru.file_bukti},
                new NpgsqlParameter("@jenis_kepesertaan", NpgsqlDbType.Varchar){Value = aktivitasKeikutsertaanBaru.jenis_kepesertaan},
                new NpgsqlParameter("@level_tingkat", NpgsqlDbType.Varchar){Value = aktivitasKeikutsertaanBaru.level_tingkat},
                new NpgsqlParameter("@poin_id_poin", NpgsqlDbType.Integer){Value = aktivitasKeikutsertaanBaru.poin_id_poin},
                new NpgsqlParameter("@mahasiswa_username", NpgsqlDbType.Varchar){Value = aktivitasKeikutsertaanBaru.mahasiswa_username},
                new NpgsqlParameter("@is_acc", NpgsqlDbType.Varchar){Value = aktivitasKeikutsertaanBaru.is_acc}
            };
            commandExecutor(query, parameters);
        }
        public static void updatePrestasi(M_Aktivitas_Keikutsertaan aktivitasKeikutsertaanEdit)
        {
            string query = $"UPDATE {table} SET nama_kegiatan = @nama_kegiatan, tanggal = @tanggal, file_bukti = @file_bukti, jenis_kepesertaan = @jenis_kepesertaan, level_tingkat = @level_tingkat, poin_id_poin = (SELECT id_poin FROM poin WHERE butir_id_butir = (SELECT id_butir FROM butir WHERE nama_butir = @tingkat_penyelenggara) AND kategori_id_kategori = @kategori), is_acc = @is_acc WHERE id_aktivitas = @id_aktivitas";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_kegiatan", NpgsqlDbType.Varchar){Value = aktivitasKeikutsertaanEdit.nama_kegiatan},
                new NpgsqlParameter("@tanggal", NpgsqlDbType.Date){Value = aktivitasKeikutsertaanEdit.tanggal},
                new NpgsqlParameter("@file_bukti", NpgsqlDbType.Varchar){Value = aktivitasKeikutsertaanEdit.file_bukti},
                new NpgsqlParameter("@jenis_kepesertaan", NpgsqlDbType.Varchar){Value = aktivitasKeikutsertaanEdit.jenis_kepesertaan},
                new NpgsqlParameter("@level_tingkat", NpgsqlDbType.Varchar){Value = aktivitasKeikutsertaanEdit.level_tingkat},
                new NpgsqlParameter("@poin_id_poin", NpgsqlDbType.Integer){Value = aktivitasKeikutsertaanEdit.poin_id_poin},
                new NpgsqlParameter("@mahasiswa_username", NpgsqlDbType.Varchar){Value = aktivitasKeikutsertaanEdit.mahasiswa_username},
                new NpgsqlParameter("@is_acc", NpgsqlDbType.Varchar){Value = aktivitasKeikutsertaanEdit.is_acc}
            };
            commandExecutor(query, parameters);
        }
        public DataTable showRekapKeikutsertaan(string username, int kategori)
        {
            string query = $"SELECT {table}.nama_kegiatan as Kegiatan, {table}.tanggal as Tanggal, {table}.file_bukti as Bukti, {table}.jenis_kepesertaan as Kepesertaan, {table}.level_tingkat as Tingkat, poin.poin as Poin FROM {table} JOIN poin ON poin.id_poin = {table}.poin_id_poin WHERE {table}.mahasiswa_username = @username and {table}.kategori_id_kategori = @kategori and {table}.is_acc = 'disetujui';";
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