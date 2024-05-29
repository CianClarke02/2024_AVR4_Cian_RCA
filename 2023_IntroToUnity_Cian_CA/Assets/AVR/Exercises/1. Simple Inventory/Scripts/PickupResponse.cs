using AVR;
using AVR.Selection;
using UnityEngine;

public class PickupResponse : MonoBehaviour, ISelectionResponse
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

            InventoryManager.Instance.AddInventory(consumableData.Description.Trim());

            Destroy(transform.gameObject);
        }
    }
}