using UnityEngine;

[DisallowMultipleComponent]
public class Mover : ExecutableBehaviour
{
    private Vector3 _currentDirection;
    private void FixedUpdate()
    {
        if (!IsExecuting)
            return;
        transform.position += _currentDirection;

    }

    public void ChangeDirection(Vector3 val) => _currentDirection = val;
}
