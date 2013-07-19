namespace Nonagon.Modular.DynamicForm.FieldAttributes
{
	/// <summary>
	/// Picture field attribute.
	/// </summary>
	public class PictureFieldAttribute : IFieldAttribute
	{
		/// <summary>
		/// Gets the type of the field.
		/// </summary>
		/// <value>The type of the field.</value>
		public FieldType SupportedFieldType {
			get { return FieldType.Picture; }
		}
	}
}

