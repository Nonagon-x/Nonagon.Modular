using System;

namespace Nonagon.Modular.DynamicForm
{
	/// <summary>
	/// Form layout size in horizontal.
	/// </summary>
	public enum FormLayoutWidth
	{
		/// <summary>
		/// The size is growing automatically by the children.
		/// </summary>
		WrapForm,
		
		/// <summary>
		/// The size adjusted to be the parent size.
		/// </summary>
		FillParent,
		
		/// <summary>
		/// The size adjusted to be average with their sibling children.
		/// </summary>
		Average
	}
}

