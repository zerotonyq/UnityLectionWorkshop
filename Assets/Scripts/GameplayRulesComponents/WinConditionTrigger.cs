using UnityEngine;
using UnityEngine.Events;
using Zenject;

[DisallowMultipleComponent]
[RequireComponent(typeof(Collider2D), typeof(Rigidbody2D))]
public class WinConditionTrigger : MonoBehaviour
{
    private UnityAction<bool> _won;
    private Collider2D _collider2D;
    [Inject] private GameConditionManager _gameConditionManager;
    private void OnValidate()
    {
        if (_collider2D == null)
            _collider2D = GetComponent<Collider2D>();
        _collider2D.isTrigger = true;
    }

    private void Awake()
    {
        _won += _gameConditionManager.GameEnded;
        _collider2D = GetComponent<Collider2D>();
    }

    private void OnDestroy()
    {
        _won -= _gameConditionManager.GameEnded;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.TryGetComponent(out IWinAchievable _)) return;
        _won?.Invoke(true);
    }
    
}
