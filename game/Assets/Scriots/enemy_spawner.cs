using System;
using System.Collections;
using Unity.Mathematics;
using UnityEngine;

public class enemy_spawner : MonoBehaviour
{
    [SerializeField] private int Time_spawn;
    [SerializeField] private GameObject _ememy;
    [SerializeField] private GameObject _parent;
    private IEnumerator coroutine;

    private void Start()
    {
        coroutine = spawn_en(Time_spawn);
        StartCoroutine(coroutine);
    }

    IEnumerator spawn_en(int wain)
    {
        Debug.Log("Запустил");
        yield return new WaitForSeconds(wain);
        Instantiate(_ememy, Vector3.zero, quaternion.identity, _parent.transform);
        coroutine = spawn_en(wain);
        StartCoroutine(coroutine);
        
    }
}
