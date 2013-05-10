using System;
using System.Collections.Generic;

using ServiceStack.OrmLite;

using Nonagon.Modular.Media.Operations;

namespace Nonagon.Modular.Media
{
	/// <summary>
	/// The functionality interface of Media module.
	/// </summary>
	public class MediaInterface : DataModuleInterface
	{
		public MediaInterface(IDbConnectionFactory dbConnectionFactory)
		: base(dbConnectionFactory) { }
		
		/// <summary>
		/// Gets all media.
		/// </summary>
		/// <returns>The media.</returns>
		/// <param name="param">Parameter.</param>
		public IEnumerable<IMedia> GetMedia(GetMediaOperation.Param param)
		{
			return Resolve<GetMediaOperation>().Execute(param);
		}
		
		/// <summary>
		/// Gets the media data.
		/// </summary>
		/// <returns>The media data.</returns>
		/// <param name="param">Parameter.</param>
		public Byte[] GetData(GetDataOperation.Param param)
		{
			return Resolve<GetDataOperation>().Execute(param);
		}
		
		/// <summary>
		/// Stores the media.
		/// </summary>
		/// <returns>The media.</returns>
		/// <param name="param">Parameter.</param>
		public Media StoreMedia(StoreMediaOperation.Param param)
		{
			return Resolve<StoreMediaOperation>().Execute(param);
		}
		
		/// <summary>
		/// Deletes the media.
		/// </summary>
		/// <returns>The number of record affected.</returns>
		/// <param name="param">Parameter.</param>
		public Int32 DeleteMedia(DeleteMediaOperation.Param param)
		{
			return Resolve<DeleteMediaOperation>().Execute(param);
		}
	}
}