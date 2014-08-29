using System;
using System.ComponentModel.DataAnnotations;

using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;

using Nonagon.Modular.Strings;

namespace Nonagon.Modular.Content
{
	/// <summary>
	/// Content class.
	/// </summary>
	public class Content : IContent, IHasId<Int64>
	{
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		[AutoIncrement]
		[Alias("ContentID")]
		public Int64 Id { get; set; }
		
		/// <summary>
		/// Gets the reference.
		/// </summary>
		/// <value>The reference.</value>
		[Required]
		[StringLength(64)]
		public String Reference { get; set; }
		
		/// <summary>
		/// Gets or sets the content key.
		/// </summary>
		/// <value>The key of content.</value>
		[Required]
		[StringLength(30)]
		public String Key { get; set; }

		/// <summary>
		/// Gets or sets the description of string.
		/// </summary>
		/// <value>The description.</value>
		[StringLength(512)]
		public LocalizedString Description { get; set; }
		
		/// <summary>
		/// Gets the created date.
		/// </summary>
		/// <value>The created date.</value>
		[Required]
		public DateTime CreatedDate { get; set; }

		/// <summary>
		/// Gets the status of form.
		/// </summary>
		/// <value>The status.</value>
		[Required]
		public ContentStatus Status { get; set; }

		/// <summary>
		/// Gets or sets the content revision.
		/// </summary>
		/// <value>The template revision.</value>
		[Ignore]
		public ContentRevision Revision { get; set; }
	}
}

