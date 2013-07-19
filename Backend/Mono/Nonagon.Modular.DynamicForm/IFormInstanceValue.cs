using System;
using Nonagon.Reflection;

namespace Nonagon.Modular.DynamicForm
{
	/// <summary>
	/// Field instance value interface.
	/// </summary>
	public interface IFormInstanceValue : IDuplicable
	{
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		Int64 Id { get; }

		/// <summary>
		/// Gets or sets the Form instance identifier.
		/// </summary>
		/// <value>The Form instance identifier.</value>
		Int64 FormInstanceId { get; set; }

		/// <summary>
		/// Gets or sets the field identifier.
		/// </summary>
		/// <value>The field identifier.</value>
		Int64 FieldId { get; set; }

		/// <summary>
		/// Gets or sets the field code.
		/// </summary>
		/// <value>The field code.</value>
		String FieldCode { get; set; }

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The value.</value>
		String Value { get; set; }
	}
}

