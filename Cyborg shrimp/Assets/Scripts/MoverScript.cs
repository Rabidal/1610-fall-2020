using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message:"All my jokes are cries for help");
    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(0.1f,0,0);
    }
}
