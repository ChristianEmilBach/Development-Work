using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] GameObject meteorPreFab;
    [SerializeField] float spawnRatePerMinute = 30;
    [SerializeField] float spawnRateIncrement = 1;

    private float spawnNext = 0;

    // Update is called once per frame
    void Update()
    {

        if (Time.time > spawnNext)
        {
            spawnNext = Time.time + (60/spawnRatePerMinute);
            spawnRatePerMinute += spawnRateIncrement;

// Replaced by the code below
            float randX = Random.Range(-8,8);
            var spawnPosition = new Vector2(
                randX, 
                transform.position.y);

//var rand = Random.Range(-NewBehaviourScript.xBorderLimit, NewBehaviourScript.xBorderLimit);
  //          var spawnPosition = new Vector2(rand, NewBehaviourScript.yBorderLimit);

                Instantiate(meteorPreFab, spawnPosition, Quaternion.identity);
        }
        
    }
}
