using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{

    float speed;

    void Start ()
    {
        speed = 5f;
    }

    void Update () 
    {
        Vector2 position = transform.position;

        position = new Vector2 (position.x, position.y + speed * Time.deltaTime);

        transform.position = position;

        Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2(1, 1));

        if(transform.position.y > max.y)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
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

/*
    public float speed = 10f;
    public float maxLifeTime = 3f;

    [SerializeField] GameObject bulletPreFab;

    public Vector3 targetVector;


    // Start is called before the first frame update
    void Start()
    {

        //Destroy(gameObject, maxLifeTime);
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(speed * Time.deltaTime * targetVector);

        
    }

    private void OnCollisionEntr(Collision coll)
    {
        if (coll.gameObject.tag.Equals("Enemy")) 
        {
        Destroy(gameObject);
        }
    }
    */
}
