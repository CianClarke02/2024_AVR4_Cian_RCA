using Sirenix.OdinInspector;
using UnityEngine;

public enum GameItemType
{
    Ammo, Health, Regen, Wrench, Fuse, Welder, Torch, Key, Note, Password, Knife, Hat, Lamp, DeathMarker, BloodStain, KnifeHolder, Bed
}

[CreateAssetMenu(fileName = "ItemData", menuName = "AVR4/Data/Item")]
public class ItemData : ScriptableObject
{
    [SerializeField]
    [Required]
    public string Name;

    [SerializeField]
    [Min(0)]
    public int Value;

    [SerializeField]
    public GameItemType Type;

    [SerializeField]
    public AudioClip PickupAudioClip;
}