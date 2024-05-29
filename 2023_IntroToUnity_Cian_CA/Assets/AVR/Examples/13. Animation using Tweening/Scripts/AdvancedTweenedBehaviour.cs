using DG.Tweening;
using System;
using UnityEngine;
using UnityEngine.Events;

public class AdvancedTweenedBehaviour : MonoBehaviour
{
    private Vector3 originalScale;
    public float scaleFactor = 0.5f;

    [Space]
    public float upDuration = 1;

    public AnimationCurve easeUpFunction;

    [Space]
    public float delayTime = 0.5f;

    [Space]
    public float downDuration = 1;

    public Ease easeDownFunction = Ease.Linear;

    public UnityEvent OnCompleteCycle;

    public bool playOnStart = true;
    private bool onPropagate = true;

    public void ScaleUp()
    {
        gameObject.transform.DOBlendableScaleBy(originalScale * scaleFactor, upDuration)
            .SetLoops(1, LoopType.Incremental)
            .SetEase(easeUpFunction)
            .OnComplete(() =>
            {
                gameObject.transform.DOBlendableScaleBy(originalScale * -1 * scaleFactor, downDuration)
                .SetDelay(delayTime)
                .SetLoops(1, LoopType.Incremental)
                .SetEase(easeDownFunction)
                .OnComplete(() =>
                {
                    if (onPropagate)
                    {
                        Debug.Log("One cycle complete!");
                        OnCompleteCycle?.Invoke();
                        onPropagate = false;
                    }
                    ScaleUp();
                });
            });
    }

    private void PrintDebug()
    {
        Debug.Log("I'm finished!");
        //testVar = -10;
    }

    private void Start()
    {
        originalScale = transform.localScale;

        if (playOnStart)
            ScaleUp();
    }
}