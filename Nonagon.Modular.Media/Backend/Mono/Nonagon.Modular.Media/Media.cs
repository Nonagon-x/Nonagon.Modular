using System;
using System.ComponentModel.DataAnnotations;

using ServiceStack.DesignPatterns.Model;
using ServiceStack.DataAnnotations;
using Nonagon.Modular.Strings;

namespace Nonagon.Modular.Media
{
	/// <summary>
	/// Media class representing physical data of media along with its attributes.
	/// </summary>
	public class Media : IMedia, IHasId<Int64>
	{
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		[AutoIncrement]
		[Alias("MediaID")]
		public Int64 Id { get; set; }

		/// <summary>
		/// Gets or sets the reference.
		/// </summary>
		/// <value>The reference.</value>
		[Required]
		[StringLength(64)]
		public String Reference { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		[Required]
		[StringLength(255)]
		public String Name { get; set; }

		/// <summary>
		/// Gets or sets the type of the MIME.
		/// </summary>
		/// <value>The type of the MIME.</value>
		[Required]
		[StringLength(30)]
		public String MimeType { get; set; }

		/// <summary>
		/// Gets or sets the data.
		/// </summary>
		/// <value>The data.</value>
		[Required]
		public Byte[] Data { get; set; }

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>The description.</value>
		[StringLength(800)]
		public LocalizedString Description { get; set; }

		/// <summary>
		/// Gets or sets the tag.
		/// </summary>
		/// <value>The tag.</value>
		[StringLength(255)]
		public String Tag { get; set; }

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
		/// Gets the status.
		/// </summary>
		/// <value>The status.</value>
		[Required]
		public MediaStatus Status { get; set; }
	}
}