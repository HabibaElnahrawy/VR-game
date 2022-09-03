using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupWeapons : MonoBehaviour
{
    public Transform gun_position;
    public float distance = 10f;
    GameObject current_gun;
    GameObject guns;
    bool can_grab;
    public bulletSpawner bsp;
    private void Update()
    {
        check_weapons();
        if(can_grab)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                if (current_gun != null)
                    drop();

                pick_up();
                bsp.enabled = true;
            }

        }

        if(current_gun!=null)
        {
            if(Input.GetKeyDown(KeyCode.Z))
            {
                drop();
                bsp.enabled = false;
            }
        }
    }
    private void check_weapons()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, distance))
        {
            if (hit.transform.tag == "canGrab")
            {
                Debug.Log("you can grab ba2a e5las");
                can_grab = true;
                guns = hit.transform.gameObject;
            }
        }
        else
            can_grab = false;
    }

    private void pick_up()
    {
        current_gun = guns;
        current_gun.transform.position = gun_position.position;
        current_gun.transform.parent = gun_position;
        current_gun.transform.localEulerAngles = new Vector3(0f, 180f, -180f);
        current_gun.GetComponent<Rigidbody>().isKinematic = true;
    }

    private void drop()
    {
        current_gun.transform.parent = null;
        current_gun.GetComponent<Rigidbody>().isKinematic = false;
        current_gun = null;
    }
}
