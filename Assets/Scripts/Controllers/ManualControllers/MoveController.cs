using UnityEngine;

public class MoveController : BaseController<Mover>
{
    [SerializeField] private FixedJoystick joystick;

    private void Update()
    {
        if(joystick.Direction.magnitude > 0f)
            RequestExecution(joystick.Direction);
        else
            RequestStopExecution();
    }

    private void RequestExecution(Vector3 val)
    {
        InheritedExecutable.ChangeDirection(val);
        InheritedExecutable.Execute();
    }
    
}
