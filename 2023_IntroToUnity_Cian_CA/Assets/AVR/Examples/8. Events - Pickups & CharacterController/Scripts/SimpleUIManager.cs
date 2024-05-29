using UnityEngine;

public class SimpleUIManager : MonoBehaviour
{
    public void HandlePickupItem(string name)
    {
        Debug.Log($"SimpleUIManager::HandlePickup collected {name} ammo");
    }
}