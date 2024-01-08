using System;
//using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField] float thrustForce = 2f;
    [SerializeField] float rotationSpeed = 120f;

    public GameObject PlayerBulletGO;
    public GameObject gun;


    Rigidbody _rigidbody;

    Vector2 thrustDirection;


    // Start is called before the first frame update
    void Start()
    {
      _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        float rotation = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;
        float thrust = Input.GetAxis("Vertical")* thrustForce;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet01 = (GameObject)Instantiate(PlayerBulletGO);
            bullet01.transform.position = gun.transform.position;
            bullet01.transform.rotation = gun.transform.rotation;
            //Instantiate(PlayerBulletGO, gun.transform.position, gun.transform.rotation);
        }

        thrustDirection = transform.right;

        
        transform.Rotate(Vector3.forward, -rotation);
        _rigidbody.AddForce(thrust * thrustDirection);
    }





    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag.Equals("Enemy")) {
        SceneManager.LoadScene("SampleScene");
        }
    }
}
