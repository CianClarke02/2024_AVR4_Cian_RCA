using UnityEngine;

[CreateAssetMenu(fileName = "RotationParameters",
    menuName = "DkIT/Scriptable Objects/Parameters/Rotation")]
public class RotationParameters : ScriptableObject
{
    [Tooltip("Sets the rotation in degrees per update")]
    public float RotationAngle = 1;

    [Tooltip("Sets the rotation axis")]
    public Vector3 RotationAxis = Vector3.up;
}