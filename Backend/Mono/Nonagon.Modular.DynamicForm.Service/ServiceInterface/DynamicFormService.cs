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
				throw new ArgumentException("param");
			
			return dynamicFormInterface.GetForms(param);
		}
		
		public Object Get(GetFormDetails param)
		{
			if(param == null)
				throw new ArgumentException("param");
			
			return dynamicFormInterface.GetFormDetails(param);
		}

		public Object Get(GetFormInstanceDetails param)
		{
			if(param == null)
				throw new ArgumentException("param");

			return dynamicFormInterface.GetFormInstanceDetails(param);
		}
		
		public Object Post(StoreForm param)
		{
			if(param == null)
				throw new ArgumentException("param");
			
			return dynamicFormInterface.StoreForm(param);
		}

		public Object Post(StoreFormInstance param)
		{
			if(param == null)
				throw new ArgumentException("param");

			return dynamicFormInterface.StoreFormInstance(param);
		}

		public Object Delete(DeleteForm param)
		{
			if(param == null)
				throw new ArgumentException("param");

			return dynamicFormInterface.DeleteForm(param);
		}

		public Object Delete(DeleteFormInstace param)
		{
			if(param == null)
				throw new ArgumentException("param");
			
			return dynamicFormInterface.DeleteFormInstance(param);
		}
	}
}

