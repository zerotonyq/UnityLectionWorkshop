using UnityEngine;
using UnityEngine.Events;

[DisallowMultipleComponent]
[RequireComponent(typeof(Collider2D), typeof(Rigidbody2D))]
public class WinConditionTrigger : MonoBehaviour
{
    public UnityAction Won;
    private Collider2D _collider2D;
    private void OnValidate()
    {
        if (_collider2D == null)
            _collider2D = GetComponent<Collider2D>();
        _collider2D.isTrigger = true;
    }

    private void Awake() => _collider2D = GetComponent<Collider2D>();

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.TryGetComponent(out IWinAchievable _)) return;
        
        Debug.Log("Won!");
        Won?.Invoke();
    }
}
