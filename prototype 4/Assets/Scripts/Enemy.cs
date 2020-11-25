using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3.0f;
    private GameObject _player;
    private Rigidbody _enemyRb;
    // Start is called before the first frame update
    void Start()
    {
        _enemyRb = GetComponent<Rigidbody>();
        _player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirections = (_player.transform.position - transform.position).normalized;
        
        _enemyRb.AddForce(lookDirections*speed);

        if (transform.position.y<-10)
        {
            Destroy(gameObject);
        }
    }
}
