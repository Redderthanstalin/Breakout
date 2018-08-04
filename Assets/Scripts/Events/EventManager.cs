using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager {

    //Fields for the Freezer Event
    static FreezerBlock freezeEventInvoker;
    static UnityAction<float> freezeEventListener;

    public static void AddFreezeEventInvoker(FreezerBlock invoker)
    {
        freezeEventInvoker = invoker;
        if(freezeEventListener != null)
        {
            freezeEventInvoker.AddFreezeEffectlistener(freezeEventListener);
        }
    }

    public static void AddFreezeEventListener(UnityAction<float> listener)
    {
        freezeEventListener = listener;
        if(freezeEventInvoker != null)
        {
            freezeEventInvoker.AddFreezeEffectlistener(listener);
        }
    }
}
