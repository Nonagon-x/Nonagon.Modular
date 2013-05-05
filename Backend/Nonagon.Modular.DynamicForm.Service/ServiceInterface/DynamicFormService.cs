using System;

namespace Nonagon.Modular.DynamicForm.Service.ServiceInterface
{
	public class DynamicFormService : ServiceStack.ServiceInterface.Service
	{
		private DynamicFormInterface dynamicFormInterface = 
			ModuleManager.GetInstance<DynamicFormModule>().GetModuleInterface();

		public Object Get(GetForms param)
		{
			if(param == null)
				throw new ArgumentNullException("param");
			
			var skip = param.Skip;
			var take = param.Take;
			
			return dynamicFormInterface.GetForms(skip, take);
		}
		
		public Object Get(GetFormDetails param)
		{
			if(param == null)
				throw new ArgumentException("param");
			
			if(param.Version == null) 
			{
				return dynamicFormInterface.GetFormDetails(param.FormId);
			}
			
			return dynamicFormInterface.GetFormDetails(param.FormId, param.Version.Value);
		}
		
		public Object Post(StoreForm param)
		{
			if(param == null)
				throw new ArgumentException("param");
			
			return dynamicFormInterface.StoreForm(param.Form);
		}

		public Object Delete(DeleteForm param)
		{
			if(param == null)
				throw new ArgumentException("param");

			return dynamicFormInterface.DeleteForm(param.FormId);
		}
	}
}

