using UnityEngine;

[DisallowMultipleComponent]
public class Rotator : ExecutableBehaviour
{
    [SerializeField, Range(-30, 30)] 
    private float rotationAnglePerTick = 1f;
    private void FixedUpdate()
    {
        if (!IsExecuting)
            return;
        transform.Rotate(0,0,rotationAnglePerTick);
    }

    public void InverseDirection(bool p) => rotationAnglePerTick = p ?
        rotationAnglePerTick *= -1 :
        rotationAnglePerTick *= 1;   

}



