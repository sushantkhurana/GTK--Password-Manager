using System;
using System.Collections.ObjectModel;
namespace DataAquistionLayer
{
	/// <summary>
	/// List of accounts for a user
	/// </summary>
	public class AccountList
	{
		
		#region private
		
		//a collection of user accounts for a particular user
		private Collection<Account> listOfUserAccounts;
		
		// the associated user for the account list
		private UserCredentials associatedUser;
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// list of user accounts
		/// </summary>
		public Collection<Account> ListOfUserAccounts
		{
			get
			{
				if(this.listOfUserAccounts == null)
				{
					this.listOfUserAccounts = new Collection<Account>();
				}
				
				return this.listOfUserAccounts;
			}
		}
		
		/// <summary>
		/// Associated User for the AccountList
		/// </summary>
		public UserCredentials AssociatedUser
		{
			get
			{
				return this.associatedUser;
			}
		}
		
		#endregion
		
		#region Constructor
		
		public AccountList (UserCredentials associatedMainUser)
		{
			this.associatedUser = associatedMainUser;
			this.InitializeFromDatabase();
		}
		
		#endregion
		
		#region public
		
		/// <summary>
		/// Add a new account to the list
		/// </summary>
		/// <param name="type">
		/// A <see cref="AccountType"/>
		/// </param>
		/// <param name="userId">
		/// A <see cref="System.String"/>
		/// </param>
		/// <param name="password">
		/// A <see cref="System.String"/>
		/// </param>
		public void AddNewAccount(AccountType type, string userId, string password)
		{
		  this.listOfUserAccounts.Add(new Account(type, userId, password));
		}
		
		/// <summary>
		/// Add a new account (overloaded)
		/// </summary>
		/// <param name="type">
		/// A <see cref="AccountType"/>
		/// </param>
		public void AddNewAccount(AccountType type)
		{
		  this.listOfUserAccounts.Add(new Account(type));
		}
		
		/// <summary>
		/// Delete an account from a list of accounts of a user
		/// </summary>
		/// <param name="account">
		/// A <see cref="Account"/>
		/// </param>
		/// <returns>
		/// Deletion successful or not
		/// A <see cref="System.Boolean"/>
		/// </returns>
		public bool DeleteAccount(Account account)
		{
			if(this.listOfUserAccounts.Contains(account))
			{
				this.listOfUserAccounts.Remove(account);
				return true;
			}
			
			return false;
		}
		
		
		#endregion
		
		#region private
	
		private void InitializeFromDatabase()
		{
			
		}
		
		#endregion
		
	}
}

