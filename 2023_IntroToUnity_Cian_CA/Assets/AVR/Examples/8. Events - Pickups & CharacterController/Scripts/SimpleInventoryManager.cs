using UnityEngine;

public class SimpleInventoryManager : MonoBehaviour
{
    [SerializeField]
    private Inventory inventory;

    public void HandleItemPickup(ItemData data)
    {
        //if i get an itemdata that i have already...
        if (inventory.Contents.ContainsKey(data))
        {
            int count = inventory.Contents[data];
            count++;
            inventory.Contents[data] = count;
        }
        else //else i get the itemdata for the first time
        {
            inventory.Contents.Add(data, 1);
        }
    }

    //[SerializeField]
    //private List<string> inventory;

    //public void HandlePickupItem(string name)
    //{
    //    Debug.Log($"InventoryManager::HandlePickup collected {name} ammo");
    //    inventory.Add(name);
    //}
}