using System;
using System.Collections.Generic;
using System.Reflection;

using ServiceStack.OrmLite;

namespace Nonagon.Modular
{
	/// <summary>
	/// Module manager.
	/// </summary>
	public static class ModuleManager
	{
		private static readonly Dictionary<Type, IModule> _loadedModules = new Dictionary<Type, IModule>();

		/// <summary>
		/// Tells Nonagon Modular to load the module in memory and also initialize the module.
		/// </summary>
		/// <returns>The instance of IModule.</returns>
		/// <typeparam name="T">The Nonagon Modular module to be loaded.</typeparam>
		public static T Load<T> () where T : IModule
		{
			return Load<T> (null);
		}

		/// <summary>
		/// Tells Nonagon Modular to load the module in memory and also initialize the module.
		/// </summary>
		/// <param name="dbConnectionFactory">Instance of IDbConnectionFactory.</param>
		/// <returns>The instance of IModule.</returns>
		/// <typeparam name="T">The Nonagon Modular module to be loaded.</typeparam>
		public static T Load<T> (IDbConnectionFactory dbConnectionFactory) where T : IModule
		{
			// Check if module is already created or not, if so, use existing one.
			if(_loadedModules.ContainsKey(typeof(T)))
				return (T)_loadedModules[typeof(T)];

			ConstructorInfo constructor;
			Object[] constructorParams;

			if(dbConnectionFactory == null)
			{
				constructor = typeof(T).GetConstructor(
					BindingFlags.NonPublic | BindingFlags.Instance, 
					null, new Type[] { }, null);

				if(constructor == null)
				{
					throw new ArgumentException("The " + typeof(T).Name + 
						" require dbConnectionFactory parameter to load.");
				}

				constructorParams = null;
			}
			else
			{
				constructor = typeof(T).GetConstructor(
					BindingFlags.NonPublic | BindingFlags.Instance, 
					null, new [] { typeof(IDbConnectionFactory) }, null);

				if(constructor == null)
				{
					throw new ArgumentException("The " + typeof(T).Name + 
						" does not require any parameters.");
				}

				constructorParams = new [] { dbConnectionFactory };
			}

			T module = (T)constructor.Invoke (constructorParams);

			if(!module.IsInitialized())
				module.Initialize();

			if(!module.IsUpToDate())
				module.Update();

			module.Register();

			// Put the created module to be referenced as singleton.
			_loadedModules[typeof(T)] = module;

			return module;
		}

		/// <summary>
		/// Determines if module is loaded.
		/// </summary>
		/// <returns><c>true</c> if module is loaded; otherwise, <c>false</c>.</returns>
		/// <typeparam name="T">The Nonagon Modular module to be used.</typeparam>
		public static Boolean IsLoaded<T>() where T : IModule
		{
			return _loadedModules.ContainsKey(typeof(T));
		}

		/// <summary>
		/// Gets the instance of loaded module.
		/// </summary>
		/// <returns>The instance of loaded module.</returns>
		/// <exception cref="ModuleNotLoadedException">The module was not loaded.</exception>
		/// <typeparam name="T">The Nonagon Modular module to be used.</typeparam>
		public static T GetInstance<T> () where T : IModule
		{
			// Check if module is already created or not, if so, use existing one.
			if(_loadedModules.ContainsKey(typeof(T)))
				return (T)_loadedModules[typeof(T)];

			throw new ModuleNotLoadedException(typeof(T));
		}
	}
}