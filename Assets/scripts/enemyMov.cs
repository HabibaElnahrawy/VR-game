using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMov : MonoBehaviour
{

    public Transform player;
   
    public float Moving_speed =0.1f;
   
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
     GameObject[] x = GameObject.FindGameObjectsWithTag("Cube");
        for(int i=0;i<=10;i++)
        {
            x[i].transform.LookAt(player);
       
           x[i].transform.position +=x[i].transform.forward*Moving_speed*Time.deltaTime;
        }
       
       
    }
}
