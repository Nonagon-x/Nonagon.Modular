using System;
using System.ComponentModel.DataAnnotations;

using ServiceStack.DataAnnotations;
using ServiceStack.DesignPatterns.Model;
using ServiceStack.OrmLite;
using Nonagon.Modular.Strings;

namespace Nonagon.Modular.DynamicForm
{
	/// <summary>
	/// Form field.
	/// </summary>
	public class FormField : IFormField, IHasId<Int64>
	{
		/// <summary>
		/// Gets the identifier of field.
		/// </summary>
		/// <value>The identifier.</value>
		[AutoIncrement]
		[Alias("FormFieldID")]
		public Int64 Id { get; set; }
		
		/// <summary>
		/// Gets or sets the Form version identifier.
		/// </summary>
		/// <value>The Form version identifier.</value>
		[Alias("FormRevisionID")]
		[ForeignKey(typeof(FormRevision), OnDelete = "CASCADE", OnUpdate = "CASCADE")]
		public Int64 FormRevisionId { get; set; }
		
		/// <summary>
		/// Gets or sets the field code. The field code is the key of field.
		/// </summary>
		/// <value>The field code.</value>
		[Required]
		[StringLength(45)]
		public String FieldCode { get; set; }
		
		/// <summary>
		/// Gets or sets the name key.
		/// </summary>
		/// <value>The name key.</value>
		[Required]
		[StringLength(800)]
		public LocalizedString Name { get; set; }
		
		/// <summary>
		/// Gets or sets the type of the field.
		/// </summary>
		/// <value>The type of the field.</value>
		[Required]
		public FieldType FieldType { get; set; }
		
		/// <summary>
		/// Gets or sets the details of field definition.
		/// </summary>
		/// <value>The field info.</value>
		[Required]
		[StringLength(Int32.MaxValue)]
		public FieldInfo FieldInfo { get; set; }
	}
}