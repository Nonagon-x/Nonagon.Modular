using System;

using ServiceStack.OrmLite;

namespace Nonagon.Modular.Media.Operations
{
	/// <summary>
	/// Get physical data operation.
	/// </summary>
	public class GetDataOperation : DataModuleOperation<GetDataOperation.Param, Byte[]>
	{
		/// <summary>
		/// GetPhysicalDataOperation parameter.
		/// </summary>
		public class Param
		{
			/// <summary>
			/// Gets or sets the content identifier.
			/// </summary>
			/// <value>The content identifier.</value>
			public Int64 MediaId { get; set; }
		}
		
		/// <summary>
		/// Execute this operation with input parameter.
		/// </summary>
		/// <param name="input">The input parameter.</param>
		public override Byte[] Execute(Param input)
		{
			using(var dbConnection = DbConnectionFactory.OpenDbConnection())
			{
				var media = dbConnection.FirstOrDefault<Media>(q => q.Id == input.MediaId);

				return media.Data;
			}
		}
	}
}

