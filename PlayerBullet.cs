using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField] GameObject bulletPreFab;
    float speed;

     public Vector3 targetVector;

    void Start ()
    {
        speed = 5f;
    }

    void Update () 
    {

     transform.Translate(speed * Time.deltaTime * targetVector);
        Vector2 position = transform.position;

        position = new Vector2 (position.x, position.y + speed * Time.deltaTime);

        transform.position = position;

        Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2(1, 1));
        Destroy(gameObject, 6);

    }

     void OnTriggerEnter(Collider other)
     {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("HIT");
        }
     }



    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag.Equals("Enemy")) 
        {
        Destroy(gameObject);
        }
    }
    
}


