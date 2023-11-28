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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms.VisualStyles;

namespace FASILKOMPOINT.App.Context
{
    internal class AktivitasSertifikasiContext : DatabaseWrapper
    {
        private 
            static string table = "aktivitas";

        public static DataTable showSertifikasi(string username, int kategori)
        {
            string query = $"SELECT ROW_NUMBER() OVER (ORDER BY {table}.tanggal) as No, {table}.judul_sertifikasi as judul_sertifikasi, CONCAT ('Tanggal: ', {table}.tanggal, '\r\n', 'Tingkat Penyelenggara: ', {table}.tingkat_penyelenggara, '\r\n', 'Nama Penyelenggara: ', {table}.nama_penyelenggara) AS Keterangan, {table}.file_bukti AS Bukti, komentar.komentar as Komentar, poin.poin as Poin FROM {table} JOIN poin ON poin.id_poin = {table}.poin_id_poin JOIN komentar ON komentar.aktivitas_id_aktivitas = {table}.id_aktivitas WHERE {table}.mahasiswa_username = @username AND {table}.kategori_id_kategori = @kategori AND ({table}.is_acc = 'menunggu' OR {table}.is_acc = 'ditolak');";
            ///string query = $"SELECT {table}.judul_sertifikasi as Judul, {table}.tanggal as Tanggal, {table}.file_bukti as Bukti, {table}.tingkat_penyelenggara as Tingkat_Penyelenggara, {table}.nama_penyelenggara as Nama_Penyelenggara, poin.poin as Poin FROM {table} JOIN poin ON poin.id_poin = {table}.poin_id_poin WHERE {table}.mahasiswa_username = @username AND {table}.kategori_id_kategori = @kategori AND ({table}.is_acc = 'menunggu' or {table}.is_acc = 'ditolak');";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@kategori", NpgsqlDbType.Integer){Value = kategori},
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = username},
            };
            DataTable dataAktivitas = queryExecutor(query, parameters);
            return dataAktivitas;
        }

        public static void addSertifikasi(M_Aktivitas_Sertifikasi aktivitasSertifikasiBaru)
        {
            string query = $"DO $$ DECLARE new_id_aktivitas INTEGER; BEGIN INSERT INTO {table} (id_aktivitas, judul_sertifikasi, tanggal, file_bukti, tingkat_penyelenggara, nama_penyelenggara, poin_id_poin, mahasiswa_username, is_acc, kategori_id_kategori) SELECT COALESCE(MAX(id_aktivitas), 0) + 1, @judul_sertifikasi, @tanggal, @file_bukti, @tingkat_penyelenggara, @nama_penyelenggara, (SELECT id_poin FROM poin WHERE butir_id_butir = (SELECT id_butir FROM butir WHERE nama_butir = @tingkat_penyelenggara) AND kategori_id_kategori = @kategori), @mahasiswa_username, @is_acc, @kategori FROM {table} RETURNING id_aktivitas INTO new_id_aktivitas; INSERT INTO komentar (id_komentar, aktivitas_id_aktivitas, komentar, tim_skpi_username) VALUES (COALESCE((SELECT MAX(id_komentar) FROM komentar), 0) + 10, new_id_aktivitas, 'Belum ada komentar', '198706192014041001'); END $$;\r\n";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@judul_sertifikasi", NpgsqlDbType.Varchar){Value = aktivitasSertifikasiBaru.judul_sertifikasi},
                new NpgsqlParameter("@tanggal", NpgsqlDbType.Date){Value = aktivitasSertifikasiBaru.tanggal},
                new NpgsqlParameter("@file_bukti", NpgsqlDbType.Varchar){Value = aktivitasSertifikasiBaru.file_bukti},
                new NpgsqlParameter("@tingkat_penyelenggara", NpgsqlDbType.Varchar){Value = aktivitasSertifikasiBaru.tingkat_penyelenggara},
                new NpgsqlParameter("@nama_penyelenggara", NpgsqlDbType.Varchar){Value = aktivitasSertifikasiBaru.nama_penyelenggara},
                new NpgsqlParameter("@is_acc", NpgsqlDbType.Varchar){Value = aktivitasSertifikasiBaru.is_acc},
                new NpgsqlParameter("@mahasiswa_username", NpgsqlDbType.Varchar){Value = aktivitasSertifikasiBaru.mahasiswa_username},
            };
            commandExecutor(query, parameters);
        }
        public static void updatePrestasi(M_Aktivitas_Sertifikasi aktivitasSertifikasiEdit)
        {
            string query = $"DO $$ DECLARE new_id_aktivitas INTEGER; BEGIN UPDATE {table} SET judul_sertifikasi = @judul_sertifikasi, tanggal = @tanggal, file_bukti = @file_bukti, tingkat_penyelenggara = @tingkat_penyelenggara, nama_penyelenggara = @nama_penyelenggara, poin_id_poin = (SELECT id_poin FROM poin WHERE butir_id_butir = (SELECT id_butir FROM butir WHERE nama_butir = @tingkat_penyelenggara) AND kategori_id_kategori = @kategori), is_acc = @is_acc WHERE id_aktivitas = @id_aktivitas RETURNING id_aktivitas INTO new_id_aktivitas; UPDATE komentar SET komentar = 'Belum ada komentar', tim_skpi_username = '198706192014041001' WHERE aktivitas_id_aktivitas = new_id_aktivitas; END $$;\r\n";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@judul_sertifikasi", NpgsqlDbType.Varchar){Value = aktivitasSertifikasiEdit.judul_sertifikasi},
                new NpgsqlParameter("@tanggal", NpgsqlDbType.Date){Value = aktivitasSertifikasiEdit.tanggal},
                new NpgsqlParameter("@file_bukti", NpgsqlDbType.Varchar){Value = aktivitasSertifikasiEdit.file_bukti},
                new NpgsqlParameter("@tingkat_penyelenggara", NpgsqlDbType.Varchar){Value = aktivitasSertifikasiEdit.tingkat_penyelenggara},
                new NpgsqlParameter("@nama_penyelenggara", NpgsqlDbType.Varchar){Value = aktivitasSertifikasiEdit.nama_penyelenggara},
                new NpgsqlParameter("@is_acc", NpgsqlDbType.Varchar){Value = aktivitasSertifikasiEdit.is_acc},
                new NpgsqlParameter("@mahasiswa_username", NpgsqlDbType.Varchar){Value = aktivitasSertifikasiEdit.mahasiswa_username},
                new NpgsqlParameter("@id_aktivitas", NpgsqlDbType.Integer){Value = aktivitasSertifikasiEdit.id_aktivitas}
            };
            commandExecutor(query, parameters);
        }
        public DataTable showRekapSertifikasi(string username, int kategori)
        {
            string query = $"SELECT ROW_NUMBER() OVER (ORDER BY {table}.tanggal) as No, {table}.judul_sertifikasi as judul_sertifikasi, CONCAT ('Tanggal: ', {table}.tanggal, '\r\n', 'Tingkat Penyelenggara: ', {table}.tingkat_penyelenggara, '\r\n', 'Nama Penyelenggara: ', {table}.nama_penyelenggara) AS Keterangan, {table}.file_bukti AS Bukti, poin.poin as Poin FROM {table} JOIN poin ON poin.id_poin = {table}.poin_id_poin WHERE {table}.mahasiswa_username = @username AND {table}.kategori_id_kategori = @kategori AND {table}.is_acc = 'disetujui';";
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