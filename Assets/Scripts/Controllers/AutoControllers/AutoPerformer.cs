using System;
using UnityEditor;
using UnityEngine;

[Serializable]
public class AutoPerformer : MonoBehaviour
{

    [SerializeField] private ExecutableBehaviour _executable;
    private void Update()
    {
        if (_executable.IsExecuting || !_executable)
            return;
        _executable.Execute();
    }
}