using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

public enum VehicleCapabilityType
{
    Fly,
    Hover,
    Warpspeed
}

public class OdinDemoBehaviour : MonoBehaviour
{
    [TabGroup("grp1", "Tab A", SdfIconType.Messenger)]
    [PreviewField(Alignment = ObjectFieldAlignment.Left)]
    public Sprite uiIcon;

    [TabGroup("grp1", "Tab A")]
    [Unit(Units.Second)]
    public int timeToLive;

    [TabGroup("grp1", "Tab A")]
    [MinMaxSlider(-50, 50, showFields: true)]
    public Vector2 explosionStrength;

    [TabGroup("grp1", "Tab B", SdfIconType.Soundwave)]
    public bool isArmed;

    [TabGroup("grp1", "Tab B")]
    [ShowIf("isArmed")]
    public int rifleClipSize;

    [TabGroup("grp1", "Tab B")]
    [ShowIf("isArmed")]
    public int handgunClipSize;

    [TabGroup("grp1", "Tab C", SdfIconType.Speedometer)]
    [FoldoutGroup("Capabilities")]
    [EnumPaging]
    public VehicleCapabilityType capabilityType1;

    [TabGroup("grp1", "Tab C")]
    [FoldoutGroup("Capabilities")]
    [EnumToggleButtons]
    public VehicleCapabilityType capabilityType2;

    [TabGroup("grp1", "Tab C")]
    [FoldoutGroup("Capabilities")]
    [EnumToggleButtons]
    public VehicleCapabilityType capabilityType3;

    [TabGroup("grp1", "Tab C")]
    [FoldoutGroup("Capabilities")]
    [EnumToggleButtons]
    public VehicleCapabilityType capabilityType4;

    [TableList(ShowIndexLabels = true)]
    public List<string> objectives;
}