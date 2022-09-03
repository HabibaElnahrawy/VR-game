using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bulletmov : MonoBehaviour
{
  
    public float speed;
    public score sc;
    void Update()
    {
        Destroy(gameObject, 5);
        transform.position +=transform.forward* Time.deltaTime*speed; 
    }
   public  void OnCollisionEnter (Collision Collision)
    {
        if(Collision.gameObject.tag == "Cube")
        {

            sc = FindObjectOfType<score>();
            sc.calculate_Score(5);
            Destroy(Collision.gameObject);
            Destroy(gameObject);
               
        }
    }
}
