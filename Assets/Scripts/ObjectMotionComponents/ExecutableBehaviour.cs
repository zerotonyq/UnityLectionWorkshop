using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecutableBehaviour : MonoBehaviour, IExecutable
{
    public void Execute() => IsExecuting = true;
    public void StopExecution() => IsExecuting = false;
    public bool IsExecuting { get; set; }
}
