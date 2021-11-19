using UnityEngine;

public class DataFilledGameEventListener : MonoBehaviour
{
    public DataFilledGameEvent Event;
    public DataFilledEvent Response;

    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised(CellBundleData cellBundleData)
    {
        Response.Invoke(cellBundleData);
    }
}