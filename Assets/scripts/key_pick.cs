using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_pick : MonoBehaviour
{
    public Transform key_position;
    public float distance = 10f;
    GameObject current_gun;
    GameObject keyss;
    bool can_grab;
   // public bulletSpawner bsp;
    private void Update()
    {
        chech_weapons();
        if (can_grab)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                if (current_gun != null)
                   

                pick_up();
               // bsp.enabled = true;
            }

        }

        if (current_gun != null)
        {
            
        }
    }
    private void chech_weapons()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, distance))
        {
            if (hit.transform.tag == "cangrabKey")
            {
                Debug.Log("you can grab ba2a e5las");
                can_grab = true;
                keyss = hit.transform.gameObject;
            }
        }
        else
            can_grab = false;
    }

    private void pick_up()
    {
        current_gun = keyss;
        current_gun.transform.position = key_position.position;
        current_gun.transform.parent = key_position;
        current_gun.transform.localEulerAngles = new Vector3(0f, 180f, -180f);
        current_gun.GetComponent<Rigidbody>().isKinematic = true;
    }

  
}
