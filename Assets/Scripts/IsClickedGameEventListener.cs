using UnityEngine;

public class IsClickedGameEventListener : MonoBehaviour
{
    public IsClickedGameEvent Event;
    public IsClickedEvent Response;

    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised(string content, Transform cellTransform)
    {
        Response.Invoke(content, cellTransform);
    }
}