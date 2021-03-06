using UnityEngine;

using JetBrains.Annotations;

namespace CommonGames.Samples.Singletons.Basic
{
	using CGTK.Utilities.Singletons;
	
	/// <summary>
	/// A MonoBehaviour Singleton that can be created explicitly or lazily. If one exists it'll use that, else it'll create one.
	/// </summary>
	public sealed class Example_MonoBehaviourSingleton_Ensured : MonoBehaviourSingleton_Ensured<Example_MonoBehaviourSingleton_Ensured>
	{
		[field: SerializeField]
		public string Info { get; [UsedImplicitly] private set; } = "Example MonoBehaviour Singleton Ensured";
	}
}