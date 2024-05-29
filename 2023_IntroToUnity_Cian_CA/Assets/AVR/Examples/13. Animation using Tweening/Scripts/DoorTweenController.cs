using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;

public class DoorTweenController : MonoBehaviour
{
    [SerializeField]
    private Vector3 moveDirection;

    [SerializeField]
    [Unit(Units.Second)]
    private float moveDuration;

    [SerializeField]
    [ReadOnly]
    private bool isOpen = false;

    public void HandleDoorOpen()
    {
        if (!isOpen)
        {
            var position = transform.localPosition;
            gameObject.transform.DOLocalMove(position + moveDirection, moveDuration)
                .SetLoops(1, LoopType.Incremental)
                .OnComplete(SetOpen);
        }
    }

    public void SetOpen()
    {
        isOpen = true;
    }

    public void SetClose()
    {
        isOpen = false;
    }

    public void HandleDoorClose()
    {
        if (isOpen)
        {
            var position = transform.localPosition;
            gameObject.transform.DOLocalMove(position - moveDirection, moveDuration)
                .SetLoops(1, LoopType.Incremental)
                .OnComplete(() => isOpen = false);
        }
    }
}