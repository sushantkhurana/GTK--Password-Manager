using System;
namespace DataAquistionLayer
{
	/// <summary>
	/// A single entity representing the credentials of a user
	/// </summary>
	public class UserCredentials: DataModelBase
	{
		#region private variables
		
		//username passed by the client
		private string userName;
		
		//password as sent by the client
		private string password;
		
		//user's first name
		private string firstName;
		
		//user's middle Name
		private string middleName;
		
		//user's last name
		private string lastName;
		
		//list of accounts corresponding to this user
		private AccountList listOfAccounts;
		
		#endregion
		
		#region properties
		
		/// <summary>
		/// property for userName - create a dynamic combobox later
		/// </summary>
		public string UserName
		{
			get
			{
				return userName;
			}
			set
			{
				userName = value;
			}
		}
		
		/// <summary>
		/// specifies password
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
		/// exposes firstName
		/// </summary>
		public string FirstName
		{
			get
			{
				return firstName;
			}
			set
			{
				firstName = value;
			}
		}
		
		/// <summary>
		/// list of Accounts for the present user
		/// </summary>
		public AccountList ListOfAccounts
		{
			get
			{
				return this.listOfAccounts;
			}
		}
		
		#endregion
		
		#region constructor
		
		public Credentials()
		{
			listOfAccounts = new AccountList(this);
			InitializeFromDatabase();
		}
		
		#endregion
				
		#region private functions
		
		private void InitializeFromDatabase()
		{
			//initialize all the instances here
		}
		
		#endregion
		
		#region public functions
		
		public bool VerifyCredentials(string userid, string passwd)
		{
			if(this.userName.Trim() == userid
			   && this.password == passwd)
			{
				return true;
			}
			
			return false;
		}
		
		#endregion
		}
}

