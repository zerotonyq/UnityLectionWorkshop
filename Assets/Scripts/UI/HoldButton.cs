using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class HoldButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public UnityAction PointerDown;
    public UnityAction PointerUp;

    public void OnPointerDown(PointerEventData eventData) => PointerDown?.Invoke();

    public void OnPointerUp(PointerEventData eventData) => PointerUp?.Invoke();
}
