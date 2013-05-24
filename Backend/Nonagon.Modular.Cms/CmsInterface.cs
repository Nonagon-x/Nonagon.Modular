using System;
using System.Collections.Generic;

using ServiceStack.OrmLite;

using Nonagon.Modular.Cms.Operations;

namespace Nonagon.Modular.Cms
{
	/// <summary>
	/// The functionality interface of CMS module.
	/// </summary>
	public class CmsInterface : DataModuleInterface
	{
		public CmsInterface(IDbConnectionFactory dbConnectionFactory)
			: base(dbConnectionFactory) { }

		/// <summary>
		/// Gets the list of contents stored in CMS module.
		/// </summary>
		/// <returns>The contents list.</returns>
		/// <param name="param">Parameter.</param>
		public IEnumerable<IContent> GetContents(GetContentsOperation.Param param)
		{
			return Resolve<GetContentsOperation>().Execute(param);
		}

		/// <summary>
		/// Gets the current content version.
		/// </summary>
		/// <returns>The current content version.</returns>
		/// <param name="param">Parameter.</param>
		public Int32 GetCurrentContentVersion(GetCurrentContentVersionOperation.Param param)
		{
			return Resolve<GetCurrentContentVersionOperation>().Execute(param);
		}
		/// <summary>
		/// Gets the content details.
		/// </summary>
		/// <returns>The content details.</returns>
		/// <param name="param">Parameter.</param>
		public Content GetContentDetails(GetContentDetailsOperation.Param param)
		{
			if(param.Version == null)
			{
				Int32 currentContentVersion = Resolve<GetCurrentContentVersionOperation>().
					Execute(new GetCurrentContentVersionOperation.Param {
						ContentId = param.ContentId,
						Key = param.Key
					});
				
				param.Version = currentContentVersion;
			}
			
			return Resolve<GetContentDetailsOperation>().Execute(param);
		}
		
		/// <summary>
		/// Stores the content.
		/// </summary>
		/// <returns>The content.</returns>
		/// <param name="param">Parameter.</param>
		public Content StoreContent(StoreContentOperation.Param param)
		{
			return Resolve<StoreContentOperation>().Execute(param);
		}
		
		/// <summary>
		/// Deletes the content.
		/// </summary>
		/// <returns>The number of record affected.</returns>
		/// <param name="param">Parameter.</param>
		public Int32 DeleteContent(DeleteContentOperation.Param param)
		{
			return Resolve<DeleteContentOperation>().Execute(param);
		}
	}
}

