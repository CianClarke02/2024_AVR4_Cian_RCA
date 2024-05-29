using AVR.Selection;
using UnityEngine;

namespace AVR.Examples
{
    public class PickupFoodResponse : MonoBehaviour, ISelectionResponse
    {
        public void OnDeselect(Transform transform)
        {
        }

        public void OnSelect(Transform transform)
        {
            //get the data of the can
            var consumableObject = transform.gameObject.GetComponent<ConsumableObject>();

            if (consumableObject != null)
            {
                var consumableData = consumableObject.ConsumableData;

                AudioSource.PlayClipAtPoint(consumableData.PickupClip, transform.position, 1);

                //add to the inventory

                //add action E to collect, show can in front of the player
                Destroy(transform.gameObject);
            }
        }
    }
}