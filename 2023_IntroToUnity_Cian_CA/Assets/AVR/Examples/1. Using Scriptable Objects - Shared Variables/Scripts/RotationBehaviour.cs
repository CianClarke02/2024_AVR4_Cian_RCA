using AVR;
using UnityEngine;

public class RotationBehaviour : MonoBehaviour
{
    [SerializeField]
    private FloatReference rotationAngle;

    [SerializeField]
    private Vector3Reference rotationAxis;

    private void Update()
    {
        gameObject.transform.Rotate(
            rotationAxis.Value,
            rotationAngle.Value,
            Space.World);
    }
}

/*
 public class RotationBehaviour : MonoBehaviour
{
    //[SerializeField]
    //private Vector3 rotationAxis;

    [SerializeField]
    private RotationParameters rotationParameters;

    //[Range(-5, 5)]
    //private float rotationAngle;

    // Update is called every frame, if the MonoBehaviour is enabled
    private void Update()
    {
        gameObject.transform.Rotate(
            rotationParameters.RotationAxis,
            rotationParameters.RotationAngle,
            Space.World);
    }
}

 */