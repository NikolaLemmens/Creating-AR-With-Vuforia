using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomTrackableEventHandler : DefaultTrackableEventHandler
{
    PlayOnStateChange playOnStateChange;

    private void Awake()
    {
        playOnStateChange = GetComponentInChildren<PlayOnStateChange>();
    }

    protected override void OnTrackingFound()

    {
        base.OnTrackingFound();
        playOnStateChange.Init();
        playOnStateChange.PlayOnAppear();
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        playOnStateChange.PlayOnDisappear();
    }




}
