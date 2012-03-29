using System;

namespace DataAquistionLayer
{
	/// <summary>
	/// Specifies the type of Account
	/// </summary>
	public enum AccountType
	{
		/// <summary>
		/// stores netbanking information
		/// </summary>
		Bank,
		
		/// <summary>
		/// stores email passwords
		/// </summary>
		Email,
		
		/// <summary>
		/// stores PAN Account Details
		/// </summary>	
		Tax,
		
		/// <summary>
		/// Social Networks - Facebook, Twitter.. etc
		/// </summary>
		SocialNetworking,
		
		/// <summary>
		/// Blogging Account
		/// </summary>
		Blog,
		
		/// <summary>
		/// Other Accounts which might not exist here
		/// </summary>
		Others
	}
}

