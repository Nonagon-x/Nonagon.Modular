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
		WrapContent,
		
		/// <summary>
		/// The size adjusted to be the parent size (exclude parent padding and it's margin).
		/// </summary>
		MatchParent,
		
		/// <summary>
		/// The size adjusted to be average with their sibling children.
		/// </summary>
		Average
	}
}

