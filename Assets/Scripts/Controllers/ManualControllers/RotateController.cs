using System;
using UnityEngine;


public class RotateController : BaseController<Rotator>
{
    [SerializeField] private HoldButton holdButton;
    [SerializeField] private bool inverseDirection;
    protected override void Awake()
    {
        base.Awake();
        InheritedExecutable.InverseDirection(inverseDirection);
        holdButton.PointerDown += RequestExecution;
        holdButton.PointerUp += RequestStopExecution;
    }

    protected void OnDestroy()
    {
        holdButton.PointerDown -= RequestExecution;
        holdButton.PointerUp -= RequestStopExecution;
    }
}
