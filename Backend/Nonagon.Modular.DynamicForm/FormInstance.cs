using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using ServiceStack.DesignPatterns.Model;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;

namespace Nonagon.Modular.DynamicForm
{
	/// <summary>
	/// Form instance.
	/// </summary>
	public class FormInstance : IFormInstance, IHasId<Int64>
	{
		/// <summary>
		/// Gets the identifier of the Form instance.
		/// </summary>
		/// <value>The identifier of the Form instance.</value>
		[AutoIncrement]
		[Alias("FormInstanceID")]
		public Int64 Id { get; internal set; }
		
		/// <summary>
		/// Gets the reference.
		/// </summary>
		/// <value>The reference.</value>
		[Required]
		[StringLength(200)]
		public String Reference { get; internal set; }
		
		/// <summary>
		/// Gets or sets the Form identifier.
		/// </summary>
		/// <value>The Form identifier.</value>
		[Alias("FormID")]
		[ForeignKey(typeof(Form), OnDelete = "CASCADE", OnUpdate = "CASCADE")]
		public Int64 FormId { get; set; }
		
		/// <summary>
		/// Gets or sets the Form revision identifier.
		/// </summary>
		/// <value>The Form revision identifier.</value>
		[Alias("FormRevisionID")]
		[ForeignKey(typeof(FormRevision), OnDelete = "CASCADE", OnUpdate = "CASCADE")]
		public Int64 FormRevisionId { get; set; }

		/// <summary>
		/// Gets the created date.
		/// </summary>
		/// <value>The created date.</value>
		[Required]
		public DateTime CreatedDate { get; internal set; }

		/// <summary>
		/// Gets the last updated date.
		/// </summary>
		/// <value>The last updated date.</value>
		[Required]
		public DateTime LastUpdatedDate { get; internal set; }

		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		/// <value>The status.</value>
		[Required]
		public FormStatus Status { get; set; }

		/// <summary>
		/// Gets or sets the Form instance values.
		/// </summary>
		/// <value>The Form instance values.</value>
		[Ignore]
		public IEnumerable<FormInstanceValue> Values { get; set; }
	}
}