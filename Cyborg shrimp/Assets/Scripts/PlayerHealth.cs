
using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float speed = 5f;
    public int score = 100;
    private void Update()
    {
        var vInput = speed * Time.deltaTime * Input.GetAxis("Vertical");
        var hInput = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        transform.Translate(hInput,vInput,0);
    }
}
