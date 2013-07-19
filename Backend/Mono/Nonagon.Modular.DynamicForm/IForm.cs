using System;

using Nonagon.Reflection;
using Nonagon.Modular.Strings;

namespace Nonagon.Modular.DynamicForm
{
	/// <summary>
	/// The Form interface.
	/// </summary>
	public interface IForm : IDuplicable
	{
		/// <summary>
		/// Gets the identifier of Form.
		/// </summary>
		/// <value>The identifier.</value>
		Int64 Id { get; }

		/// <summary>
		/// Gets the unique reference key of Form.
		/// </summary>
		/// <value>The reference.</value>
		String Reference { get; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		LocalizedString Name { get; set; }

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
		/// Gets the status of Form.
		/// </summary>
		/// <value>The status.</value>
		FormStatus Status { get; }
	}
}