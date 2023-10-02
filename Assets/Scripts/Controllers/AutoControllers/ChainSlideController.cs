using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainSlideController : BaseController<Slider>
{
    [SerializeField] private bool isCycled = false;
    [SerializeField] private List<Vector3> positions = new List<Vector3>();
    public int currentPositionIndex = 0;
    private void Update()
    {
        if (executable.IsExecuting || !executable)
            return;
        if (currentPositionIndex + 1 >= positions.Count)
        {
            if (isCycled)
            {
                currentPositionIndex = 0;
                positions.Reverse();
            }
            return;
        }
            
        RequestExecution(positions[currentPositionIndex], positions[currentPositionIndex + 1]);
        ++currentPositionIndex;
    }

    private void RequestExecution(Vector3 current, Vector3 next)
    {
        InheritedExecutable.ChangePositions(current, next);
        InheritedExecutable.Execute();
    }
    private void OnDrawGizmosSelected()
    {
        for (int i = 0; i - 1 < positions.Count; ++i)
        {
            Gizmos.DrawSphere(positions[i], 0.1f);
            Gizmos.DrawLine(positions[i], positions[i+1]);
            Gizmos.DrawSphere(positions[i+1], 0.1f);   
        }
    }
    
}
