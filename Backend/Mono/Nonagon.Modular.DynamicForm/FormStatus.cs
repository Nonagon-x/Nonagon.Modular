namespace Nonagon.Modular.DynamicForm
{
	/// <summary>
	/// Form related status.
	/// </summary>
	public enum FormStatus
	{
		/// <summary>
		/// The data is active for use.
		/// </summary>
		Active = 1,

		/// <summary>
		/// The data is not active for use.
		/// </summary>
		Inactive = 0,

		/// <summary>
		/// The data has been deleted.
		/// </summary>
		Deleted = -1
	}
}

