using System;
using UnityEngine;

public class BaseController<T> : MonoBehaviour where T : ExecutableBehaviour
{
    [SerializeField] 
    protected ExecutableBehaviour executable;
    protected T InheritedExecutable;
    protected virtual void Awake()
    {
        InheritedExecutable = executable as T;
        if (!InheritedExecutable)
            throw new NullReferenceException();
    }

    protected void RequestExecution()
    {
        InheritedExecutable.Execute();
    }

    protected void RequestStopExecution()
    {
        InheritedExecutable.StopExecution();
    }
}
