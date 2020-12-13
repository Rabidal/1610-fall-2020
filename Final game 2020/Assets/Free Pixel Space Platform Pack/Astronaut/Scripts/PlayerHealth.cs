using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    public bool hasDied;
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        hasDied = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y<-8)
        {
            hasDied=true;
        }

        if (hasDied==true)
        {
            StartCoroutine(Die());
        }

        IEnumerator Die()
        {
            SceneManager.LoadScene("First");
            yield return null;
        }
    }
}
