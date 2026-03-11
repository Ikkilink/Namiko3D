using UnityEngine;
using UnityEngine.Events;

public class EventListener : MonoBehaviour
{
    public EventSO gameEvent;
    public UnityEvent response;

    void OnEnable()
    {
        gameEvent.Register(this);
    }

    void OnDisable()
    {
        gameEvent.Unregister(this);
    }

    public void invokeEvent()
    {
        response.Invoke();
    }
}
