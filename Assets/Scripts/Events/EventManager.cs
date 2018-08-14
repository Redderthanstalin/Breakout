using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager {

    static PickupBlock freezeEventInvoker;
    static UnityAction<float> freezeEventListener;

    static PickupBlock speedupEventInvoker;
    static UnityAction<float, float> speedupEventListener;

    public static void AddFreezerEventInvoker(PickupBlock invoker)
    {
        freezeEventInvoker = invoker;
        if(freezeEventListener != null)
        {
            freezeEventInvoker.AddFreezerEffectListener(freezeEventListener);
        }
    }

    public static void AddFreezerEventListener(UnityAction<float> listener)
    {
        freezeEventListener = listener;
        if(freezeEventInvoker != null)
        {
            freezeEventInvoker.AddFreezerEffectListener(listener);
        }
    }

    public static void AddSpeedupEventInvoker(PickupBlock invoker)
    {
        speedupEventInvoker = invoker;
        if(speedupEventListener != null)
        {
            speedupEventInvoker.AddSpeedupEffectListener(speedupEventListener);
        }
    }

    public static void AddSpeedupEventlistener(UnityAction<float,float> listener)
    {
        speedupEventListener = listener;
        if(speedupEventInvoker != null)
        {
            speedupEventInvoker.AddSpeedupEffectListener(listener);
        }
    }
}
