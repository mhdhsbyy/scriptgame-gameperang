using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [Header("Spawn Object")]
    public GameObject Character;
    public Transform spawnposition;
    public Transform player;

    [Header("Spawn Setting")]
    // delay digunakan untuk perulangan pemanggilan spawner
    [SerializeField] protected float spawndelay = 2f;
    // waktu sebelum dipanggil pertama kali
    [SerializeField] protected float spawninterval = 3f;

    private void Start()
    {
        // 1. Function
        // 2. Waktu Delay
        // 3. Waktu Interval
        // Digunakan khusus untuk melakukan perulangan function
        InvokeRepeating(nameof(Spawner), spawndelay, spawninterval);
    }

    void Spawner()
    {
        Vector2 direction = new Vector2(player.position.x + 10, player.position.y);

        // 3 bagian
        // 1. object
        // 2. posisi
        // 3. rotasi
        Instantiate(Character, direction, Quaternion.identity);
        //spawnposition.position
    }
}
