using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[DisallowMultipleComponent]
public class Slider : ExecutableBehaviour
{
    [SerializeField] private Vector3 startPosition;
    [SerializeField] private Vector3 endPosition;
    [SerializeField] private float time = 1f;
    private float _remainingTime = 0f;
    private void FixedUpdate()
    {
        if (!IsExecuting)
            return;
        if (_remainingTime < time)
        {
            _remainingTime += Time.fixedDeltaTime;
            transform.position = Vector3.Lerp(startPosition, endPosition, _remainingTime/time);    
        }
        else
        {
            (startPosition,endPosition) = (endPosition, startPosition);
            _remainingTime = 0f;
            StopExecution();
        }
    }

    public void ChangePositions(Vector3 start, Vector3 end)
    {
        startPosition = start;
        endPosition = end;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawSphere(startPosition, 0.1f);
        Gizmos.DrawLine(startPosition, endPosition);
        Gizmos.DrawSphere(endPosition, 0.1f);
    }
}
