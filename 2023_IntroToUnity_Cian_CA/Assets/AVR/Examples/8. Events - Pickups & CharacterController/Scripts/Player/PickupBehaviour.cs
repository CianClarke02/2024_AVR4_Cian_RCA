using AVR;
using System;
using UnityEngine;

/// <summary>
/// Sends an event (with int amount) when we collided with an object with the target tag
/// </summary>
public class PickupBehaviour : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Raise this event when we collide with a pickup with the target tag")]
    private ItemDataGameEvent OnItemPickup;

    [SerializeField]
    [Tooltip("Specify the target tag for the pickup")]
    private string targetTag;

    private void Awake()
    {
        if (OnItemPickup == null)
            throw new ArgumentNullException("Did you forget to create an IntGameEvent and connect to this behaviour?");

        //just in case we use add extra whitespaces
        targetTag.Trim();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals(targetTag))
        {
            var container = other.gameObject.GetComponent<ItemDataContainer>();

            if (container != null)
            {
                OnItemPickup?.Raise(container.Data);
                Destroy(other.gameObject);
            }
        }
    }
}

/*
 public class PickupBehaviour : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Raise this event when we collide with a pickup with the target tag")]
    private IntGameEvent OnPickupEvent;

    [SerializeField]
    [Tooltip("Specify the target tag for the pickup")]
    private string targetTag = "Ammo";

    private void Awake()
    {
        if (OnPickupEvent == null)
            throw new ArgumentNullException("Did you forget to create an IntGameEvent and connect to this behaviour?");

        //just in case we use add extra whitespaces
        targetTag.Trim();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals(targetTag))
        {
            OnPickupEvent?.Raise(50);
            Destroy(other.gameObject);
            //play sound
        }
    }
}
 */