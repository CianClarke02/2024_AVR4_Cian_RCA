using AVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupEventSender : MonoBehaviour
{
    [SerializeField]
    private IntGameEvent OnPickup;

    private int value;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            OnPickup.Raise(value);
            value--;
        }
    }
}