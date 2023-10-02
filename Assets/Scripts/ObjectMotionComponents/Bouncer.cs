using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Collider2D))]
public class Bouncer : MonoBehaviour
{
    [SerializeField, Range(0, 10f)] private float bounceFactor = 1f;
    private Collider2D _collider;
    void Awake()
    {
        _collider = GetComponent<Collider2D>();
        _collider.sharedMaterial = new PhysicsMaterial2D
        {
            bounciness = bounceFactor
        };
    }
}
