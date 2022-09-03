 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float t;
    private float remaingTime ;
    int count_enemy;
    void Start()
    {
        remaingTime =t;
       
    }

    // Update is called once per frame
    void Update()
    {
        remaingTime-= Time.deltaTime;
        if(remaingTime<0)
        {
            while(count_enemy<5)
            {
             GameObject b = Instantiate(enemy);
             b.transform.position = new Vector3 (Random.Range(23.77f, 36.17f), -17.16f, Random.Range(13.33f, 16.33f));
             remaingTime =t;
             count_enemy += 1;
            }
        }
    }
}
