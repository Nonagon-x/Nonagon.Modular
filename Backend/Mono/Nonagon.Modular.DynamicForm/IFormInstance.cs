using System;

using Nonagon.Reflection;

namespace Nonagon.Modular.DynamicForm
{
	/// <summary>
	/// Form instance interface.
	/// </summary>
	public interface IFormInstance : IDuplicable
	{
		/// <summary>
		/// Gets the identifier of the Form instance.
		/// </summary>
		/// <value>The identifier of the Form instance.</value>
		Int64 Id { get; }

		/// <summary>
		/// Gets the reference.
		/// </summary>
		/// <value>The reference.</value>
		String Reference { get; }

		/// <summary>
		/// Gets or sets the Form identifier.
		/// </summary>
		/// <value>The Form identifier.</value>
		Int64 FormId { get; set; }

		/// <summary>
		/// Gets or sets the Form revision identifier.
		/// </summary>
		/// <value>The Form revision identifier.</value>
		Int64 FormRevisionId { get; set; }

		/// <summary>
		/// Gets the created date.
		/// </summary>
		/// <value>The created date.</value>
		DateTime CreatedDate { get; }

		/// <summary>
		/// Gets the last updated date.
		/// </summary>
		/// <value>The last updated date.</value>
		DateTime LastUpdatedDate { get; }

		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		/// <value>The status.</value>
		FormStatus Status { get; set; }
	}
}