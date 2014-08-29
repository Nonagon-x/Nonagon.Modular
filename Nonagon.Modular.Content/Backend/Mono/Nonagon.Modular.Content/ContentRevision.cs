using System;
using System.ComponentModel.DataAnnotations;

using ServiceStack.DesignPatterns.Model;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;

using Nonagon.Modular.Strings;

namespace Nonagon.Modular.Content
{
	/// <summary>
	/// Content revision.
	/// </summary>
	public class ContentRevision : IContentRevision, IHasId<Int64>
	{
		/// <summary>
		/// Gets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		[AutoIncrement]
		[Alias("ContentRevisionID")]
		public Int64 Id { get; set; }
		
		/// <summary>
		/// Gets the content identifier.
		/// </summary>
		/// <value>The content identifier.</value>
		[Alias("ContentID")]
		[ForeignKey(typeof(Content), OnDelete = "CASCADE", OnUpdate = "CASCADE")]
		public Int64 ContentId { get; set; }
		
		/// <summary>
		/// Gets or sets the version.
		/// </summary>
		/// <value>The version.</value>
		[Required]
		public Int32 Version { get; set; }

		/// <summary>
		/// Gets or sets the content.
		/// </summary>
		/// <value>The content.</value>
		[Required]
		public Object ContentBody { get; set; }
		
		/// <summary>
		/// Gets the created date.
		/// </summary>
		/// <value>The created date.</value>
		[Required]
		public DateTime CreatedDate { get; set; }
		
		/// <summary>
		/// Gets the last updated date.
		/// </summary>
		/// <value>The last updated date.</value>
		[Required]
		public DateTime LastUpdatedDate { get; set; }
		
		/// <summary>
		/// Gets the keywords.
		/// </summary>
		/// <value>The keywords separated by comma.</value>
		[StringLength(1024)]
		public String Keywords { get; set; }
		
		/// <summary>
		/// Gets the status.
		/// </summary>
		/// <value>The status.</value>
		[Required]
		public ContentStatus Status { get; set; }
	}
}

