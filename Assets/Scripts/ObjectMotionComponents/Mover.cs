using UnityEngine;
using UnityEngine.Serialization;

[DisallowMultipleComponent]
public class Mover : ExecutableBehaviour
{
    [SerializeField]
    private Vector3 currentDirection;
    [SerializeField, Range(0,2f)]
    private float speedModifier = 0.1f;
    private void FixedUpdate()
    {
        if (!IsExecuting)
            return;
        transform.position += currentDirection * speedModifier;

    }

    public void ChangeDirection(Vector3 val) => currentDirection = val;
}
