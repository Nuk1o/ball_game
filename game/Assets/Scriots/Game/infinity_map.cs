using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infinity_map : MonoBehaviour
{
    [SerializeField] private GameObject _map;
    [SerializeField] private float speed;

    private void Start()
    {
        _map.transform.position = new Vector3(2.14f, 0, 0);
    }

    private void FixedUpdate()
    {
        _map.transform.position = new Vector3(_map.transform.position.x - speed , 0, 0);
        if (_map.transform.position.x < -24.58f)
        {
            _map.transform.position = new Vector3(2.14f, 0, 0);
        }
    }
}
