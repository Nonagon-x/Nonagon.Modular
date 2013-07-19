using System;
using System.ComponentModel.DataAnnotations;

using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;

using Nonagon.Modular.Strings;

namespace Nonagon.Modular.DynamicForm
{
	/// <summary>
	/// Form class.
	/// </summary>
	public class Form : IForm, IHasId<Int64>
	{
		/// <summary>
		/// Gets the identifier of Form.
		/// </summary>
		/// <value>The identifier.</value>
		[AutoIncrement]
		[Alias("FormID")]
		public Int64 Id { get; set; }

		[Required]
		[StringLength(64)]
		public String Code { get; set; }

		/// <summary>
		/// Gets the unique reference key of Form.
		/// </summary>
		/// <value>The reference.</value>
		[Required]
		[StringLength(64)]
		public String Reference { get; set; }

		/// <summary>
		/// Gets or sets the name key.
		/// </summary>
		/// <value>The name key.</value>
		[Required]
		[StringLength(800)]
		public LocalizedString Name { get; set; }

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
		/// Gets the status of Form.
		/// </summary>
		/// <value>The status.</value>
		[Required]
		public FormStatus Status { get; set; }

		/// <summary>
		/// Gets or sets the template revision.
		/// </summary>
		/// <value>The template revision.</value>
		[Ignore]
		public FormRevision Revision { get; set; }
	}
}