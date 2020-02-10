using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{
    public GameObject explosion;
    public float hit = 0;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit detected");
        
        hit += 1;
        Debug.Log(hit);

            if (hit == 5)
        {
            Debug.Log("Game Over");
        }
            if (hit == 10)
        {
            Debug.Log("The Game is over, Please stop playing");
        }
            if (hit >= 15)
        {
            Debug.Log("Ouch!");
            GameObject e = Instantiate(explosion) as GameObject;
            e.transform.position = transform.position;
            Destroy(other.gameObject);
            this.gameObject.SetActive(false);
        }
    }
}