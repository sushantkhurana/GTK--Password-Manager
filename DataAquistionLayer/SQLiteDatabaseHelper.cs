using System;
using Mono.Data.Sqlite;
using System.Data;

namespace DataAquistionLayer
{
	public static class SQLiteDatabaseHelper
	{
		#region private
		
		private static IDbConnection dbcon;
		
		private const string connectionString = "URI=file:ProjectDatabase.db";
		
		private static IDataReader reader;
		
		#endregion
		
		#region properties
		
		public static IDataReader Reader
		{
			get
			{
				return reader;
			}
		}
		
		#endregion
		
		#region public helper methods
		
		public static IDataReader ExecuteQuery(string sql)
		{
			dbcon = (IDbConnection) new SqliteConnection(connectionString);
       		dbcon.Open();
       		IDbCommand dbcmd = dbcon.CreateCommand();    

       		dbcmd.CommandText = sql;
			
       		reader = dbcmd.ExecuteReader();

		}
		
		public static void ExecuteNonQueryOrScalar(string sql)
		{
			dbcon = (IDbConnection) new SqliteConnection(connectionString);
       		dbcon.Open();
       		IDbCommand dbcmd = dbcon.CreateCommand();    

       		dbcmd.CommandText = sql;
			
			dbcmd.ExecuteNonQuery();
			
			
		}
		#endregion
		
		#region call this everytime you fetch a reader
		
		public static void CleanUpReader()
		{			
       		// clean up
       		reader.Close();
       		reader = null;
       		dbcmd.Dispose();
       		dbcmd = null;
       		dbcon.Close();
       		dbcon = null;
		}
		
		#endregion
	}
	
}
