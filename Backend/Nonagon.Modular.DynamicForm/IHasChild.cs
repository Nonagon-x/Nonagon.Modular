namespace Nonagon.Modular.DynamicForm
{
	/// <summary>
	/// The interface for all Form element which will have only one child.
	/// </summary>
	public interface IHasChild
	{
		/// <summary>
		/// Gets or sets the child element
		/// </summary>
		/// <value>The child element.</value>
		IFormElement Child { get; set; }
	}
}

