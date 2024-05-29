using System;
using UnityEngine;

public class HighlightBehaviour : MonoBehaviour
{
    [Header("Position Properties")]
    [SerializeField]
    private Vector3 positionOffset;

    [Header("Scale Properties")]
    [SerializeField]
    [Range(0.01f, 0.2f)]
    private float scaleMultiplier = 0.1f;

    [SerializeField]
    [Range(0, 20)]
    private float scaleSpeedMultiplier = 0.8f;

    [Header("Rotation Properties")]
    [SerializeField]
    [Range(-1f, 1f)]
    private float rotationDegreesPerUpdate = 0.1f;

    private Vector3 originalScale;

    private void Awake()
    {
        originalScale = transform.localScale;
    }

    public void SetPosition(Vector3 position)
    {
        //store original to always scale from original
        gameObject.transform.position = position + positionOffset;
    }

    public void SetActive(bool isActive)
    {
        gameObject.SetActive(isActive);
    }

    private void Update() //60Hz -> 16ms
    {
        //rotate
        gameObject.transform.Rotate(gameObject.transform.up, rotationDegreesPerUpdate);
        //scale
        var scale = (scaleMultiplier * Mathf.Sin(scaleSpeedMultiplier * Time.time)) + 1;
        gameObject.transform.localScale = scale * originalScale;
    }
}