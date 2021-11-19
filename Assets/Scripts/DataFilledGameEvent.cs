using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New DataFilledGameEvent", menuName = "DataFilledGameEvent")]
public class DataFilledGameEvent : ScriptableObject
{
	private List<DataFilledGameEventListener> listeners = new List<DataFilledGameEventListener>();

	public void Raise(CellBundleData cellBundleData)
	{
		for (int i = listeners.Count - 1; i >= 0; i--)
			listeners[i].OnEventRaised(cellBundleData);
	}

	public void RegisterListener(DataFilledGameEventListener listener)
	{
		listeners.Add(listener);
	}

	public void UnregisterListener(DataFilledGameEventListener listener)
	{
		listeners.Remove(listener);
	}
}