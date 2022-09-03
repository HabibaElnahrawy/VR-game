using HTC.UnityPlugin.Vive;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ir : MonoBehaviour
{
    //  private FixedJoint joint = null;
    private Rigidbody rigidbody = null;
    //private List<Rigidbody> rigidbodies = new List<Rigidbody>();
    //GameObject ll;
    public GameObject Bullet;
    public GameObject gun;
    //private bool is_grabbed = false;
    void Start()
    {

    }
    public float speed;
    private GameObject curr_obj;
    // Update is called once per frame
    void Update()
    {


        if (ViveInput.GetTriggerValue(HandRole.RightHand) > 0.5f)
        {
            Collider[] coll = Physics.OverlapSphere(this.transform.position, 0.5f);
            if (coll.Length != 0)
            {
                curr_obj = coll[0].gameObject;
                curr_obj.transform.parent = this.transform;
                curr_obj.GetComponent<Rigidbody>().isKinematic = true;
               
            }


        }
        
            if (ViveInput.GetPressDown(HandRole.RightHand, ControllerButton.Trigger))
            {
                if (gun.Equals( curr_obj))

                    {
                        GameObject b = Instantiate(Bullet, transform.position, transform.rotation);
                    }

            }
      

       

    }

  
    
}
