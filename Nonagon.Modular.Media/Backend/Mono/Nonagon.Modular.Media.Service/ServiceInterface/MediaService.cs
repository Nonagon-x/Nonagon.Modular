using System;

namespace Nonagon.Modular.Media.Service.ServiceInterface
{
	public class MediaService : ServiceStack.ServiceInterface.Service
	{
		private MediaInterface mediaInterface = 
			ModuleManager.GetInstance<MediaModule>().GetModuleInterface();
		
		public Object Get(GetMedia param)
		{
			if(param == null)
				throw new ArgumentException("param");
			
			return mediaInterface.GetMedia(param);
		}
		
		public Object Get(GetData param)
		{
			if(param == null)
				throw new ArgumentException("param");
			
			return mediaInterface.GetData(param);
		}
		
		public Object Post(StoreMedia param)
		{
			if(param == null)
				throw new ArgumentException("param");
			
			return mediaInterface.StoreMedia(param);
		}
		

		public Object Delete(DeleteMedia param)
		{
			if(param == null)
				throw new ArgumentException("param");
			
			return mediaInterface.DeleteMedia(param);
		}
	}
}

