using UnityEngine;

namespace AVR
{
    public class HighlightTargetController : MonoBehaviour
    {
        // [HideInInspector]
        private Vector3 targetPosition;

        public Vector3 TargetPosition
        {
            get => targetPosition;
            set => targetPosition = value;
        }

        private void Update()
        {
            gameObject.transform.position = targetPosition;
        }
    }
}