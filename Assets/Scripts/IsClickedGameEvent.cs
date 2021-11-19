using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New IsClickedGameEvent", menuName = "IsClickedGameEvent")]
public class IsClickedGameEvent : ScriptableObject
{
	private List<IsClickedGameEventListener> listeners = new List<IsClickedGameEventListener>();

	public void Raise(string content, Transform cellTransform)
	{
		for (int i = listeners.Count - 1; i >= 0; i--)
			listeners[i].OnEventRaised(content, cellTransform);
	}

	public void RegisterListener(IsClickedGameEventListener listener)
	{
		listeners.Add(listener);
	}

	public void UnregisterListener(IsClickedGameEventListener listener)
	{
		listeners.Remove(listener);
	}
}