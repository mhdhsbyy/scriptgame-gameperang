//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]

public class PlayerMovement : Move
{
    //public float speed = 5;
    //public string name;
    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    float x = Input.GetAxis("Horizontal");
    //    float y = Input.GetAxis("Vertical");

    //    transform.Translate(new Vector2(x, y).normalized * speed * Time.deltaTime);
    //}

    public void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        currentinput = input.normalized;
    }
}
