using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    [SerializeField] int points = 5;
    [SerializeField] float maxLifeTime = 6;

    
    void Start()
    {
        // máximos segundos de vida para los asteroides
        Destroy(gameObject, maxLifeTime);
        GetComponent<Rigidbody>().AddForce(new Vector3(0,-speed*100,0));

    }

/*
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
    
    */
}