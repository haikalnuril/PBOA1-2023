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
            string query = $"SELECT ROW_NUMBER() OVER (ORDER BY {table}.tanggal) as No, {table}.nama_kegiatan as Nama, CONCAT('Tanggal: ', {table}.tanggal, '\r\n', 'Tingkat: ', {table}.level_tingkat, '\r\n', 'Jenis: ', {table}.jenis_kepesertaan) as Keterangan, {table}.file_bukti as Bukti,{table}.is_acc as Status, komentar.komentar as Komentar, poin.poin as Poin FROM {table} JOIN poin ON poin.id_poin = {table}.poin_id_poin JOIN komentar ON komentar.aktivitas_id_aktivitas = {table}.id_aktivitas WHERE {table}.mahasiswa_username = @username AND {table}.kategori_id_kategori = @kategori AND ({table}.is_acc = 'menunggu' OR {table}.is_acc = 'ditolak');";
            ///string query = $"SELECT {table}.nama_kegiatan as Kegiatan, {table}.tanggal as Tanggal, {table}.file_bukti as Bukti, {table}.jenis_kepesertaan as Kepesertaan, {table}.level_tingkat as Tingkat, poin.poin as Poin FROM {table} JOIN poin ON poin.id_poin = {table}.poin_id_poin WHERE {table}.mahasiswa_username = @username AND {table}.kategori_id_kategori = @kategori AND ({table}.is_acc = 'menunggu' or {table}.is_acc = 'ditolak');";
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
            string query = $"DO $$ DECLARE new_id_aktivitas INTEGER; BEGIN INSERT INTO {table} (id_aktivitas, nama_kegiatan, tanggal, file_bukti, jenis_kepesertaan, level_tingkat, poin_id_poin, mahasiswa_username, is_acc, kategori_id_kategori) VALUES (COALESCE((SELECT MAX(id_aktivitas) FROM {table}), 0)+1, @nama_kegiatan, @tanggal, @file_bukti, @jenis_kepesertaan, @level_tingkat, (SELECT id_poin FROM poin WHERE butir_id_butir = (SELECT id_butir FROM butir WHERE nama_butir = @level_tingkat) AND subbutir_id_subbutir = (SELECT id_subbutir FROM subbutir WHERE nama_butir = @jenis_kepesertaan) AND kategori_id_kategori = @kategori), @mahasiswa_username, @is_acc, @kategori) RETURNING id_aktivitas INTO new_id_aktivitas; INSERT INTO komentar (id_komentar, aktivitas_id_aktivitas, komentar, tim_skpi_username) VALUES (COALESCE((SELECT MAX(id_komentar) FROM komentar), 0) + 10, new_id_aktivitas, 'Belum ada komentar', '198706192014041001'); END $$;\r\n";
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
        public static void updateKeikutsertaan(M_Aktivitas_Keikutsertaan aktivitasKeikutsertaanEdit)
        {
            string query = $"DO $$ DECLARE new_id_aktivitas INTEGER; BEGIN UPDATE {table} SET nama_kegiatan = @nama_kegiatan, tanggal = @tanggal, file_bukti = @file_bukti, jenis_kepesertaan = @jenis_kepesertaan, level_tingkat = @level_tingkat, poin_id_poin = (SELECT id_poin FROM poin WHERE butir_id_butir = (SELECT id_butir FROM butir WHERE nama_butir = @tingkat_penyelenggara) AND kategori_id_kategori = @kategori), is_acc = @is_acc WHERE id_aktivitas = @id_aktivitas RETURNING id_aktivitas INTO new_id_aktivitas; UPDATE komentar SET komentar = 'Belum ada komentar', tim_skpi_username = '198706192014041001' WHERE aktivitas_id_aktivitas = new_id_aktivitas; END $$;\r\n";
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
            string query = $"SELECT ROW_NUMBER() OVER (ORDER BY {table}.tanggal) as No, {table}.nama_kegiatan as Nama, CONCAT('Tanggal: ', {table}.tanggal, '\r\n', 'Tingkat: ', {table}.level_tingkat, '\r\n', 'Jenis: ', {table}.jenis_kepesertaan) as Keterangan, {table}.file_bukti as Bukti,{table}.is_acc as Status, poin.poin as Poin FROM {table} JOIN poin ON poin.id_poin = {table}.poin_id_poin WHERE {table}.mahasiswa_username = @username AND {table}.kategori_id_kategori = @kategori AND {table}.is_acc = 'disetujui';";
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