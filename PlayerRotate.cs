using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRotate : MonoBehaviour
{
    public void OnLook(InputValue value)
    {
        Vector2 mouseposition = Camera.main.ScreenToWorldPoint(value.Get<Vector2>());
        LookAt(mouseposition);
    }

    private float Angle(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }

    protected void LookAt(Vector3 target)
    {
        float lookAngle = Angle(transform.position, target) + 90;
        transform.eulerAngles = new Vector3(0, 0, lookAngle);
    }
}
