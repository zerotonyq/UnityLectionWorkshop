using System;
using UnityEngine;
using UnityEngine.Events;
using Zenject;

[DisallowMultipleComponent]
public class WinAchiever : MonoBehaviour, IWinAchievable, IDestroyable
{
    [Inject]
    private GameConditionManager _gameConditionManager;
    
    private void Awake() => DestroyAction += _gameConditionManager.GameEnded;
    private void OnDestroy() => DestroyAction -= _gameConditionManager.GameEnded;
    
    public void Destroy()
    {
        DestroyAction?.Invoke(false);
    }
    public UnityAction<bool> DestroyAction { get; set; }
}
