using System;
namespace DataAquistionLayer
{
	/// <summary>
	/// A single account
	/// </summary>
	public class Account : DataModelBase
	{
		#region private
		
		//the type of account
		private AccountType accountType;
		
		//what the account is all about
		private string accountInfo;
		
		//the user id of the account
		private string userId;
		
		//the passcode
		private string password;
		
		//notes describing something about the account
		private string notes;
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// exposes accountType
		/// </summary>
		public AccountType AccountType
		{
			get
			{
				return accountType;
			}
			set
			{
				accountType=value;
			}				
		}
		
		/// <summary>
		/// exposes accountInfo
		/// </summary>
		public string AccountInfo
		{
			get
			{
				return accountInfo;
			}
			set
			{
				accountInfo=value;
			}
		}
		
		
		/// <summary>
		/// exposes userId
		/// </summary>
		public string UserId
		{
			get
			{
				return userId;
			}
			set
			{
				userId = value;
			}
		}
		
		/// <summary>
		/// exposes password
		/// </summary>
		public string Password
		{
			get
			{
				return password;
			}
			set
			{
				password = value;
			}
		}
		
		/// <summary>
		/// exposes notes
		/// </summary>
		public string Notes
		{
			get
			{
				return notes;
			}
			set
			{
				notes = value;
			}
		}
			
		#endregion	
			
		#region constructor
		
		public Account (AccountType TypeOfAccount)
		{
			this.accountType = TypeOfAccount;
		}
		
		public Account(AccountType TypeOfAccount, string user, string pass)
		{
			this.accountType = TypeOfAccount;
			this.userId = user;
			this.password = pass;
		}
		
		#endregion
	}
}

