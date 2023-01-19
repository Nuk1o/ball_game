using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_controll : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private int Speed_up;

    private void Start()
    {
        transform.position = new Vector3(-7, 0, 0);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _rigidbody2D.AddForce(new Vector2(0,Speed_up));
        }
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "enemy")
        {
            SceneManager.LoadScene("Game_over");
        }
    }
}
