using System;

using ServiceStack.DesignPatterns.Model;

using Nonagon.Reflection;

namespace Nonagon.Modular.DynamicForm
{
	/// <summary>
	/// The Form revision interface.
	/// </summary>
	public interface IFormRevision : IDuplicable
	{
		/// <summary>
		/// Gets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		Int64 Id { get; }

		/// <summary>
		/// Gets the Form identifier.
		/// </summary>
		/// <value>The Form identifier.</value>
		Int64 FormId { get; }

		/// <summary>
		/// Gets or sets the version of revision.
		/// </summary>
		/// <value>The version.</value>
		Int32 Version { get; set; }

		/// <summary>
		/// Gets or sets the template of Form.
		/// </summary>
		/// <value>The template.</value>
		FormTemplate Template { get; set; }

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
		/// Gets the status.
		/// </summary>
		/// <value>The status.</value>
		FormStatus Status { get; }
	}
}

