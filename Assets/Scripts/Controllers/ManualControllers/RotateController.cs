using UnityEngine;

public class RotateController : MonoBehaviour
{
    [SerializeField] private Rotator rotator; 
    private void OnEnable()
    {
        
        rotator.Execute();
    }
}
