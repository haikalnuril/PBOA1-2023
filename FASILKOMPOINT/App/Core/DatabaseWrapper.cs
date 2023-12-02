using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASILKOMPOINT.App.Core
{
	internal class DatabaseWrapper
	{
		/*
        - File ini berisi konfigurasi koneksi ke database yang didefine sekali tetapi bisa digunakan berkali-kali oleh banyak Context yang membutuhkan.
        - File ini akan berisikan:
            1. Properti credential database dan koneksinya
            2. Method open dan close koneksi
            3. Method Command & Query Wrapper {Command => [C, U, D], Query = [R]}
        */

		// Properti credential database dan koneksinya
		private static readonly string DB_HOST = "localhost";
		private static readonly string DB_DATABASE = "FASILKOMPOINT";
		private static readonly string DB_USERNAME = "postgres";
<<<<<<< HEAD
		private static readonly string DB_PASSWORD = "admin123";
=======
		private static readonly string DB_PASSWORD = "haikalteng12";
>>>>>>> b67706f70a1fb1dda3683d2c5aeb968b78e9cf58
		private static readonly string DB_PORT = "5432";

		private static NpgsqlConnection connection;
		private static NpgsqlCommand command;

		// Method open dan close Koneksi
		public static void openConnection()
		{
			connection = new NpgsqlConnection($"Host={DB_HOST};Username={DB_USERNAME};Password={DB_PASSWORD};Database={DB_DATABASE};Port={DB_PORT}");
			connection.Open();
			command = new NpgsqlCommand();
			command.Connection = connection;
		}

		public static void closeConnection()
		{
			connection.Close();
			command.Parameters.Clear();
		}

		public static DataTable queryExecutor(string query, NpgsqlParameter[] parameters = null)
		{
			try
			{
				openConnection();
				DataTable dataTable = new DataTable();
				command.CommandText = query;
				if (parameters != null)
				{
					command.Parameters.AddRange(parameters);
					command.Prepare();
				}
				NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
				dataAdapter.Fill(dataTable);
				closeConnection();
				return dataTable;
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}
		public static void commandExecutor(string query, NpgsqlParameter[] parameters = null)
		{
			try
			{
				openConnection();
				command.CommandText = query;
				command.Parameters.AddRange(parameters);
				command.Prepare();
				command.Parameters.Clear();
				command.ExecuteNonQuery();
				closeConnection();
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}

		public static int commandExecutorIntValue(string query, NpgsqlParameter[] parameters = null)
		{
			int value = 0;
			try
			{
				openConnection();
				command.CommandText = query;
				command.Parameters.AddRange(parameters);
				command.Prepare();

				object result = command.ExecuteScalar();
				if (result != null && result != DBNull.Value)
				{
					value = Convert.ToInt32(result);
				}

				closeConnection();
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
			return value;
		}
    }
}