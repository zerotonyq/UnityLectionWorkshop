using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] private Mover mover; 
    private void Start()
    {
        
        mover.Execute();
    }
}
