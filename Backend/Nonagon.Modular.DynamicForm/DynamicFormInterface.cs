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
		public Int32 GetCurrentFormVersion(Int64 FormId)
		{
			return Resolve<GetCurrentFormVersionOperation>().Execute(FormId);
		}

		/// <summary>
		/// Gets the Form details of current Form version.
		/// </summary>
		/// <returns>The Form details.</returns>
		/// <param name="FormId">Form identifier.</param>
		public Form GetFormDetails(Int64 FormId)
		{
			Int32 currentFormVersion = Resolve<GetCurrentFormVersionOperation>().Execute(FormId);
			return Resolve<GetFormDetailsOperation>().Execute(
				new GetFormDetailsOperation.Param() {
					FormId = FormId,
					Version = currentFormVersion
				});
		}

		/// <summary>
		/// Gets the Form details from specified version.
		/// </summary>
		/// <returns>The Form details.</returns>
		/// <param name="FormId">Form identifier.</param>
		/// <param name="version">Version.</param>
		public Form GetFormDetails(Int64 FormId, Int32 version)
		{
			return Resolve<GetFormDetailsOperation>().Execute(
				new GetFormDetailsOperation.Param() {
				FormId = FormId,
				Version = version
			});
		}

		/// <summary>
		/// Stores the Form.
		/// </summary>
		/// <returns>The Form.</returns>
		/// <param name="FormDetails">Form details.</param>
		public Form StoreForm(Form FormDetails)
		{
			return Resolve<StoreFormOperation>().Execute(FormDetails);
		}

		/// <summary>
		/// Deletes the Form.
		/// </summary>
		/// <returns>The Form.</returns>
		/// <param name="FormId">Form identifier.</param>
		public Int32 DeleteForm(Int64 FormId)
		{
			return Resolve<DeleteFormOperation>().Execute(FormId);
		}

		/// <summary>
		/// Stores the Form instance.
		/// </summary>
		/// <returns>The Form instance.</returns>
		/// <param name="FormInstance">Form instance.</param>
		public FormInstance StoreFormInstance(FormInstance FormInstance)
		{
			return Resolve<StoreFormInstanceOperation>().Execute(FormInstance);
		}

		/// <summary>
		/// Gets the Form instance details.
		/// </summary>
		/// <returns>The Form instance details.</returns>
		/// <param name="FormInstanceId">Form instance identifier.</param>
		public FormInstance GetFormInstanceDetails(Int64 FormInstanceId)
		{
			return Resolve<GetFormInstanceDetailsOperation>().Execute(FormInstanceId);
		}
	}
}