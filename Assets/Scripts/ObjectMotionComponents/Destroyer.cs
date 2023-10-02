using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D), typeof(Rigidbody2D))]
public class Destroyer : MonoBehaviour
{
    private Collider2D _collider2D;
    private void OnValidate()
    {
        if (_collider2D == null)
            _collider2D = GetComponent<Collider2D>();
        _collider2D.isTrigger = true;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent(out IDestroyable destroyable))
        {
            destroyable.Destroy();
        }
    }
}
