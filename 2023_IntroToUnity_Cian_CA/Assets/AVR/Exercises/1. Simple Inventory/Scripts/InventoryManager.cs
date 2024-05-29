using AVR;

/// <summary>
/// UNUSED - from an earlier incomplete exercise (with a vending machine)
/// </summary>
public class InventoryManager : Singleton<InventoryManager>
{
    public int x;

    private SerializableDictionary items;

    private void Awake()
    {
        items = GetComponent<SerializableDictionary>();
    }

    public void AddInventory(string itemName)
    {
        if (items[itemName] != null)
        {
            IntVariable intVar = items[itemName] as IntVariable;
            intVar.Value += 1;
        }
    }

    //private void Update()
    //{
    //    IntVariable ammo = items["ammo"] as IntVariable;
    //    IntVariable battery = items["battery"] as IntVariable;
    //    Debug.Log($"{ammo.Value}, {battery.Value}");
    //}
}