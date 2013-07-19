using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;
using ServiceStack.OrmLite;

namespace Nonagon.Modular.DynamicForm
{
	/// <summary>
	/// Form revision class.
	/// </summary>
	public class FormRevision : IFormRevision, IHasId<Int64>
	{
		/// <summary>
		/// Gets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		[AutoIncrement]
		[Alias("FormRevisionID")]
		public Int64 Id { get; set; }
		
		/// <summary>
		/// Gets the Form identifier.
		/// </summary>
		/// <value>The Form identifier.</value>
		[Alias("FormID")]
		[ForeignKey(typeof(Form), OnDelete = "CASCADE", OnUpdate = "CASCADE")]
		public Int64 FormId { get; set; }
		
		/// <summary>
		/// Gets or sets the version of revision.
		/// </summary>
		/// <value>The version.</value>
		[Required]
		public Int32 Version { get; set; }

		[StringLength(Int32.MaxValue)]
		public String Output { get; set; }

		/// <summary>
		/// Gets or sets the template of Form.
		/// </summary>
		/// <value>The template.</value>
		[StringLength(Int32.MaxValue)]
		public FormTemplate Template { get; set; }
		
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
		public FormStatus Status { get; set; }

		/// <summary>
		/// Gets or sets the fields definition.
		/// </summary>
		/// <value>The fields.</value>
		[Ignore]
		public IEnumerable<FormField> Fields { get; set; }
	}
}