﻿namespace AVR
{
    /// <summary>
    /// Used to specify if an onscreen object (e.g. a waypoint) is always shown
    /// </summary>
    public enum VisibilityStrategyType : sbyte
    {
        NeverShow,
        ShowWithin,
        AlwaysShow
    }
}