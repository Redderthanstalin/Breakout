using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EffectUtils {

    static SpeedupEffectMonitor speedupEffectMonitor;

    public static float Duration
    {
        get { return speedupEffectMonitor.Duration; }
    }

    public static float SpeedupFactor
    {
        get { return speedupEffectMonitor.SpeedupFactor; }
    }

    public static bool IsSpeedup
    {
        get { return speedupEffectMonitor.IsSpeedup; }
    }

    public static void Initialize()
    {
        speedupEffectMonitor = Camera.main.GetComponent<SpeedupEffectMonitor>();
    }
}
