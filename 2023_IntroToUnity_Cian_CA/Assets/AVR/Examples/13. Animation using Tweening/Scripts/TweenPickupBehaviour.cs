using DG.Tweening;
using UnityEngine;

public class TweenPickupBehaviour : MonoBehaviour
{
    [SerializeField]
    private float rotationDuration = 4;

    [SerializeField]
    private float scaleDuration = 0.5f;

    [SerializeField]
    private float colorDuration = 1;

    [SerializeField]
    private float moveDuration = 1;

    [SerializeField]
    private Vector3 moveVector;

    [SerializeField]
    private Ease moveEaseFunction = Ease.InOutSine;

    [SerializeField]
    private Ease rotateEaseFunction = Ease.Linear;

    [SerializeField]
    private Ease colorEaseFunction = Ease.InOutSine;

    [SerializeField]
    [Range(1, 2)]
    private float scaleFactor = 1.1f;

    private void Start()
    {
        var material = GetComponent<Renderer>().material;

        if (material != null)
        {
            material.DOColor(Color.red, colorDuration)
                 .SetLoops(-1, LoopType.Yoyo)
                   .SetEase(colorEaseFunction);
        }

        var targetLocalPosition = transform.localPosition + moveVector;

        gameObject.transform.DOLocalMove(targetLocalPosition, moveDuration)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(moveEaseFunction);

        gameObject.transform.DOLocalRotate(new Vector3(0, 180, 0), rotationDuration)
            .SetLoops(-1, LoopType.Incremental)
            .SetEase(rotateEaseFunction);

        gameObject.transform.DOBlendableScaleBy(scaleFactor * Vector3.one, scaleDuration)
             .SetLoops(-1, LoopType.Yoyo);
    }
}