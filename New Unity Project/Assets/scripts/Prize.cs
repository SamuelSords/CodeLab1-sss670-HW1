using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

        private void OnTriggerEnter2D(Collider2D other)
        {
            transform.position = new Vector2(Random.Range(-6, 6), Random.Range(-4, 4));
        }
    }

