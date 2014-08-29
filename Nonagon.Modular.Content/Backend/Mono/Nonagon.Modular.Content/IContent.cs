using System;
using Nonagon.Reflection;
using Nonagon.Modular.Strings;

namespace Nonagon.Modular.Content
{
	/// <summary>
	/// The content interface.
	/// </summary>
	public interface IContent : IDuplicable
	{
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		Int64 Id { get; }

		/// <summary>
		/// Gets the reference.
		/// </summary>
		/// <value>The reference.</value>
		String Reference { get; }

		/// <summary>
		/// Gets or sets the content key.
		/// </summary>
		/// <value>The key of content.</value>
		String Key { get; set; }

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>The description.</value>
		LocalizedString Description { get; set; }

		/// <summary>
		/// Gets the created date.
		/// </summary>
		/// <value>The created date.</value>
		DateTime CreatedDate { get; }

		/// <summary>
		/// Gets the status of form.
		/// </summary>
		/// <value>The status.</value>
		ContentStatus Status { get; }
	}
}

