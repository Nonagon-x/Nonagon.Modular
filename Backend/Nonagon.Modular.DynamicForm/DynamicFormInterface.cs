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
		/// Gets all Forms.
		/// </summary>
		/// <returns>The all Forms.</returns>
		/// <param name="skip">Number of records to skip.</param>
		/// <param name="take">Number of records to take.</param>
		public IEnumerable<IForm> GetForms(Int32 skip, Int32 take)
		{
			var param = new GetFormsOperation.Param() {
				Skip = skip,
				Take = take
			};

			return Resolve<GetFormsOperation>().Execute(param);
		}

		/// <summary>
		/// Gets the current Form version.
		/// </summary>
		/// <returns>The last active Form version.</returns>
		/// <param name="FormId">Form identifier.</param>
		public Int32 GetCurrentFormVersion(Int64 formId)
		{
			return Resolve<GetCurrentFormVersionOperation>().Execute(formId);
		}

		/// <summary>
		/// Gets the Form details of current Form version.
		/// </summary>
		/// <returns>The Form details.</returns>
		/// <param name="FormId">Form identifier.</param>
		public Form GetFormDetails(Int64 formId)
		{
			Int32 currentFormVersion = Resolve<GetCurrentFormVersionOperation>().Execute(formId);
			return Resolve<GetFormDetailsOperation>().Execute(
				new GetFormDetailsOperation.Param() {
					FormId = formId,
					Version = currentFormVersion
				});
		}

		/// <summary>
		/// Gets the Form details from specified version.
		/// </summary>
		/// <returns>The Form details.</returns>
		/// <param name="FormId">Form identifier.</param>
		/// <param name="version">Version.</param>
		public Form GetFormDetails(Int64 formId, Int32 version)
		{
			return Resolve<GetFormDetailsOperation>().Execute(
				new GetFormDetailsOperation.Param() {
				FormId = formId,
				Version = version
			});
		}

		/// <summary>
		/// Stores the Form.
		/// </summary>
		/// <returns>The Form.</returns>
		/// <param name="FormDetails">Form details.</param>
		public Form StoreForm(Form formDetails)
		{
			return Resolve<StoreFormOperation>().Execute(formDetails);
		}

		/// <summary>
		/// Deletes the Form.
		/// </summary>
		/// <returns>The Form.</returns>
		/// <param name="FormId">Form identifier.</param>
		public Int32 DeleteForm(Int64 formId)
		{
			return Resolve<DeleteFormOperation>().Execute(formId);
		}

		/// <summary>
		/// Stores the Form instance.
		/// </summary>
		/// <returns>The Form instance.</returns>
		/// <param name="FormInstance">Form instance.</param>
		public FormInstance StoreFormInstance(FormInstance formInstance)
		{
			return Resolve<StoreFormInstanceOperation>().Execute(formInstance);
		}

		/// <summary>
		/// Gets the Form instance details.
		/// </summary>
		/// <returns>The Form instance details.</returns>
		/// <param name="FormInstanceId">Form instance identifier.</param>
		public FormInstance GetFormInstanceDetails(Int64 formInstanceId)
		{
			return Resolve<GetFormInstanceDetailsOperation>().Execute(formInstanceId);
		}
	}
}