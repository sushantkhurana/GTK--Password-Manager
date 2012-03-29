using System;
namespace DataAquistionLayer
{
	public class DataModelBase
	{
		//The id of the DataModel
		private uint id;
		
		/// <summary>
		/// exposes id
		/// </summary>
		public uint Id
		{
			get
			{
				return id;
			}
			protected set
			{
				id = value;
			}
		}
		
		public DataModelBase ()
		{
			
		}
	}
}

