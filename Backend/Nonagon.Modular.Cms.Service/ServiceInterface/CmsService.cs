using System;

namespace Nonagon.Modular.Cms.Service.ServiceInterface
{
	public class CmsService : ServiceStack.ServiceInterface.Service
	{
		private CmsInterface cmsInterface = 
			ModuleManager.GetInstance<CmsModule>().GetModuleInterface();

		public Object Get(GetContents param)
		{
			if(param == null)
				throw new ArgumentException("param");
			
			return cmsInterface.GetContents(param);
		}
		
		public Object Get(GetContentDetails param)
		{
			if(param == null)
				throw new ArgumentException("param");
			
			return cmsInterface.GetContentDetails(param);
		}

		public Object Post(StoreContent param)
		{
			if(param == null)
				throw new ArgumentException("param");
			
			return cmsInterface.StoreContent(param);
		}

		public Object Delete(DeleteContent param)
		{
			if(param == null)
				throw new ArgumentException("param");

			return cmsInterface.DeleteContent(param);
		}
	}
}

