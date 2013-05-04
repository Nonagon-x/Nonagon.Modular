using System;
using Nonagon.Modular.Strings;
using Nonagon.Reflection;

namespace Nonagon.Modular.Cms
{
	/// <summary>
	/// Content revision interface.
	/// </summary>
	public interface IContentRevision : IDuplicable
	{
		/// <summary>
		/// Gets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		Int64 Id { get; }

		/// <summary>
		/// Gets the content identifier.
		/// </summary>
		/// <value>The content identifier.</value>
		Int64 ContentId { get; }

		/// <summary>
		/// Gets or sets the version.
		/// </summary>
		/// <value>The version.</value>
		Int32 Version { get; set; }

		/// <summary>
		/// Gets or sets the text.
		/// </summary>
		/// <value>The text.</value>
		LocalizedString Text { get; set; }

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
		/// Gets the keywords.
		/// </summary>
		/// <value>The keywords separated by comma.</value>
		String Keywords { get; }
		
		/// <summary>
		/// Gets the status.
		/// </summary>
		/// <value>The status.</value>
		ContentStatus Status { get; }
	}
}

