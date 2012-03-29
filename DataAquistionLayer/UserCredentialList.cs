using System;
using System.Collections.ObjectModel;
using Mono.Data.Sqlite;

namespace DataAquistionLayer
{
	/// <summary>
	/// list of users in the software
	/// </summary>
	public class UserCredentialList
	{
		
		#region private
		
		//list of users in the application
		private Collection<UserCredentials> listOfUsers; 
		
		#endregion
		
		#region properties
		
		/// <summary>
		/// list of users
		/// </summary>
		public Collection<UserCredentials> ListOfUsers
		{
			get
			{
				return listOfUsers;
			}
		}
		
		/// <summary>
		/// singleton
		/// </summary>
		public static UserCredentialList GetInstance
		{
			get
			{
				return new UserCredentialList();
			}
		}
		
		#endregion
		
		#region constructor
		
		/// <summary>
		/// cannot be created externally
		/// </summary>
		private UserCredentialList ()
		{
			listOfUsers=new Collection<UserCredentials>();
			InitializeFromDatabase();
		}
		
		#endregion
		
		#region private methods
		
		private void InitializeFromDatabase()
		{
		}
		
		#endregion
		
		#region public methods
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="userName">
		/// A <see cref="System.String"/>
		/// </param>
		/// <param name="password">
		/// A <see cref="System.String"/>
		/// </param>
		/// <param name="firstName">
		/// A <see cref="System.String"/>
		/// </param>
		/// <param name="middleName">
		/// A <see cref="System.String"/>
		/// </param>
		/// <param name="lastName">
		/// A <see cref="System.String"/>
		/// </param>
		public void AddNewUser(string userName, string password, string firstName, string middleName, string lastName)
		{
			//add name and stuff to the list
			this.listOfUsers.Add(new UserCredentials());
		}
		
		#endregion
	}
}

