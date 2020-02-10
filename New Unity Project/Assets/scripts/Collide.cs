using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{
    public GameObject explosion;
    public float h = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit detected");
        
        h += 1;
        Debug.Log(h);

            if (h == 5)
        {
            Debug.Log("Game Over");
        }
            if (h == 10)
        {
            Debug.Log("The Game is over, Please stop playing");
        }
            if (h >= 15)
        {
            Debug.Log("Ouch!");
            GameObject e = Instantiate(explosion) as GameObject;
            e.transform.position = transform.position;
            Destroy(other.gameObject);
            this.gameObject.SetActive(false);
        }
    }
}