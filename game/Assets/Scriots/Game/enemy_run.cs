using System;
using UnityEngine;
using Random = System.Random;

public class enemy_run : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private GameObject parent_d;

    private void Start()
    {
        Random rnd = new Random();
        transform.position = new Vector3(13, rnd.Next(-4, 4), 0);
        transform.Rotate(0,0,rnd.Next(0,360));
        int size_trl = rnd.Next(2, 6);
        transform.localScale = new Vector3(size_trl, size_trl, 0);
        Debug.Log(transform.position);
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x - _speed, transform.position.y, 0);
        if (transform.position.x < -24)
        {
            Destroy(parent_d);
        }
    }
}
