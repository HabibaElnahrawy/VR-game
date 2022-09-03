using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class seekerMov : MonoBehaviour
{

    public float Speed;
    
    public score scco;

    public Transform player;
    

    void Start()
    {
        
        Destroy(gameObject, 5);

    }


    void Update()
    {

        transform.position += transform.forward * Time.deltaTime * Speed;
    }


    public void OnCollisionEnter(Collision Collision)
    {
       
        if (Collision.gameObject.tag == "Cube")
        {

            scco = FindObjectOfType<score>();
            scco.calculate_Score(10);
          
            Destroy(Collision.gameObject);
            Destroy(gameObject);

        }

    }
  
    
    
}