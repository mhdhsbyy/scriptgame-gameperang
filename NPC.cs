using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public Transform target;
    //int hp = 100;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(1, 4, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0, 0, 90 * Time.deltaTime);

        //transform.localScale = new Vector3(5, 5, 1);

        ////posisi caspule - perubahan posisi;
        //Vector2 direction = target.position - transform.position;
        //Math.Atan 2 untuk mengihitung sudut;
        //float angel = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        //transform.rotation = Quaternion.Euler(0, 0, angel + 90);

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    hp = hp - 25;
        //    Debug.Log("Sisa Darah : " + hp);
        //    //transform.localScale = new Vector3(5, 5, 1);
        //    if (hp < 30)
        //    {
        //        transform.localScale = new Vector3(5, 5, 1);
        //        Debug.Log("Musuh marah dan membesar !");
        //    }
        //}

        // pertemuan 6

            Vector2 direction = target.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            transform.rotation = Quaternion.Euler(0, 0, angle + 90);
    }
}
