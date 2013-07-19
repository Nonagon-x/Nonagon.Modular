namespace Nonagon.Modular.DynamicForm
{
	/// <summary>
	/// The interface for all Form element group.
	/// </summary>
	public interface IFormElementGroup : IFormElement
	{
		/// <summary>
		/// Gets or sets the layout type this element will use.
		/// </summary>
		/// <value>The layout type.</value>
		FormLayoutType LayoutType { get; set; }
		
		/// <summary>
		/// Gets or sets the orientation.
		/// </summary>
		/// <value>The orientation.</value>
		FormLayoutOrientation Orientation { get; set; }
	}
}

