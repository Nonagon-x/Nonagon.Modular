using System;
using System.ComponentModel.DataAnnotations;

using ServiceStack.DesignPatterns.Model;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;

namespace Nonagon.Modular.DynamicForm
{
	/// <summary>
	/// Form instance value.
	/// </summary>
	public class FormInstanceValue : IFormInstanceValue, IHasId<Int64>
	{
		/// <summary>
		/// Gets the identifier of the Form instance.
		/// </summary>
		/// <value>The identifier of the Form instance.</value>
		[AutoIncrement]
		[Alias("FormInstanceValueID")]
		public Int64 Id { get; set; }
		
		/// <summary>
		/// Gets or sets the Form instance identifier.
		/// </summary>
		/// <value>The Form instance identifier.</value>
		[Alias("FormInstanceID")]
		[ForeignKey(typeof(FormInstance), OnDelete = "CASCADE", OnUpdate = "CASCADE")]
		public Int64 FormInstanceId { get; set; }
		
		/// <summary>
		/// Gets or sets the field identifier.
		/// </summary>
		/// <value>The field identifier.</value>
		[Alias("FieldID")]
		[ForeignKey(typeof(FormField))]
		public Int64 FieldId { get; set; }
		
		/// <summary>
		/// Gets or sets the field code.
		/// </summary>
		/// <value>The field code.</value>
		[Required]
		[StringLength(45)]
		public String FieldCode { get; set; }

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The value.</value>
		[Required]
		public String Value { get; set; }
	}
}

