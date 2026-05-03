using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Move : MonoBehaviour
{
    [SerializeField] protected float speed;
    protected Rigidbody2D body;
    protected Vector2 currentinput;

    // akan dipanggil sebelum game dimulai
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // fixedupdate pemanggilan berulang berdasarkan fisika
    private void FixedUpdate()
    {
        body.velocity = speed * currentinput;
    }
}
