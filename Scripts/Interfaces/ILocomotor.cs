﻿#if UNITY_EDITOR
namespace UnityEditor.Experimental.EditorVR
{
	/// <summary>
	/// Decorates a class as a locomotion implementer that uses the Viewer Pivot
	/// </summary>
	public interface ILocomotor : IUsesViewerPivot
	{
	}
}
#endif
