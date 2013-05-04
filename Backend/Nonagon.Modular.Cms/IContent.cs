using System;
using Nonagon.Reflection;

namespace Nonagon.Modular.Cms
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
		/// Gets the status of form.
		/// </summary>
		/// <value>The status.</value>
		ContentStatus Status { get; }
	}
}

