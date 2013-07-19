using System;

namespace Nonagon.Modular.DynamicForm
{
	/// <summary>
	/// Form layout type.
	/// </summary>
	public enum FormLayoutType
	{
		/// <summary>
		/// The linear layout. All children will be stacked in the specified Orientation.
		/// </summary>
		LinearLayout,

		/// <summary>
		/// The wrap layout. All children will be stacked just like linear layout. 
		/// But will also wrap to next row if overflow.
		/// </summary>
		WrapLayout
	}
}

