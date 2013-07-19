using System;
using System.Collections.Generic;

using ServiceStack.OrmLite;

using Nonagon.Modular.DynamicForm.Operations;

namespace Nonagon.Modular.DynamicForm
{
	/// <summary>
	/// The functionality interface of Dynamic Form module.
	/// </summary>
	public class DynamicFormInterface : DataModuleInterface
	{
		public DynamicFormInterface(IDbConnectionFactory dbConnectionFactory)
			: base(dbConnectionFactory) { }

		/// <summary>
		/// Gets all forms.
		/// </summary>
		/// <returns>The forms.</returns>
		/// <param name="param">Parameter.</param>
		public IEnumerable<IForm> GetForms(GetFormsOperation.Param param)
		{
			return Resolve<GetFormsOperation>().Execute(param);
		}

		/// <summary>
		/// Gets the current form version.
		/// </summary>
		/// <returns>The current form version.</returns>
		/// <param name="param">Parameter.</param>
		public Int32 GetCurrentFormVersion(GetCurrentFormVersionOperation.Param param)
		{
			return Resolve<GetCurrentFormVersionOperation>().Execute(param);
		}

		/// <summary>
		/// Gets the form details.
		/// </summary>
		/// <returns>The form details.</returns>
		/// <param name="param">Parameter.</param>
		public Form GetFormDetails(GetFormDetailsOperation.Param param)
		{
			if(param.Version == null)
			{
				Int32 currentFormVersion = Resolve<GetCurrentFormVersionOperation>().
					Execute(new GetCurrentFormVersionOperation.Param {
						FormId = param.FormId
					});

				param.Version = currentFormVersion;
			}

			return Resolve<GetFormDetailsOperation>().Execute(param);
		}

		/// <summary>
		/// Stores the form.
		/// </summary>
		/// <returns>The form.</returns>
		/// <param name="param">Parameter.</param>
		public Form StoreForm(StoreFormOperation.Param param)
		{
			return Resolve<StoreFormOperation>().Execute(param);
		}

		/// <summary>
		/// Deletes the form.
		/// </summary>
		/// <returns>The number of record affected.</returns>
		/// <param name="param">Parameter.</param>
		public Int32 DeleteForm(DeleteFormOperation.Param param)
		{
			return Resolve<DeleteFormOperation>().Execute(param);
		}

		/// <summary>
		/// Stores the form instance.
		/// </summary>
		/// <returns>The form instance.</returns>
		/// <param name="param">Parameter.</param>
		public FormInstance StoreFormInstance(StoreFormInstanceOperation.Param param)
		{
			return Resolve<StoreFormInstanceOperation>().Execute(param);
		}

		/// <summary>
		/// Gets the form instance details.
		/// </summary>
		/// <returns>The form instance details.</returns>
		/// <param name="param">Parameter.</param>
		public FormInstance GetFormInstanceDetails(GetFormInstanceDetailsOperation.Param param)
		{
			return Resolve<GetFormInstanceDetailsOperation>().Execute(param);
		}

		/// <summary>
		/// Deletes the form instance.
		/// </summary>
		/// <returns>The number of record affected.</returns>
		/// <param name="param">Parameter.</param>
		public Int32 DeleteFormInstance(DeleteFormInstanceOperation.Param param)
		{
			return Resolve<DeleteFormInstanceOperation>().Execute(param);
		}
	}
}