using UnityEngine;

[DisallowMultipleComponent]
public class Slider : ExecutableBehaviour
{
    [SerializeField] private Vector3 startPosition;
    [SerializeField] private Vector3 endPosition;
    [SerializeField] private float time;
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

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawSphere(startPosition, 0.1f);
        Gizmos.DrawLine(startPosition, endPosition);
        Gizmos.DrawSphere(endPosition, 0.1f);
    }
}
