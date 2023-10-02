using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class StartController : BaseController<ExecutableBehaviour>
{
    [SerializeField] private Button button;

    private UnityAction _delayStartControllerAction;
    private void Start()
    {
        _delayStartControllerAction = () => RequestExecution();
        button.onClick.AddListener(_delayStartControllerAction);
    }

    private void OnDestroy()
    {
        button.onClick.RemoveListener(_delayStartControllerAction);
    }
}
