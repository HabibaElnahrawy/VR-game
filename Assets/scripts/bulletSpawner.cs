using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletSpawner : MonoBehaviour
{
    public GameObject closest_enemy = null;
    public GameObject Bullet;
    public GameObject seekerBullet;
    private bool isNormal;


    public GameObject player;
    // public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            if (isNormal)
            {


                GameObject b = Instantiate(Bullet, transform.position, transform.rotation);

            }
            else
            {
                SearchClosest();
                // GameObject seeker =Instantiate(seekerBullet, closest.transform.position, closest.transform.rotation);
                //GameObject seeker = Instantiate(seekerBullet, transform.position, transform.rotation);
                GameObject seeker = Instantiate(seekerBullet, closest_enemy.transform.position, Quaternion.identity);
            }
        }

    }
    public void changeBulletType(bool isNN)
    {
        isNormal = true;

    }
    public void check(bool isSeeker)
    {
        isNormal = false;
    }

    public void SearchClosest()
    {
        // GameObject closest = null;
        // GameObject[] x = GameObject.FindGameObjectsWithTag("Cube");
        // float min_dis = 2000;
        //Vector3 position = player.transform.position;


        //for (int i = 0; i <= x.Length; i++)
        // {
        // Vector3 distance = x[i].transform.position - position;
        //float elDistancemMaintenant = distance.sqrMagnitude;
        // float distance = Vector3.Distance(gameObject.transform.position, x[i].transform.position);
        // if (elDistancemMaintenant < min_dis)
        //{
        //   closest = x[i];
        //   min_dis = elDistancemMaintenant;
        //  x[i].transform.position =closest;
        //  x[i].transform.LookAt(closest);
        // GameObject seeker = Instantiate(seekerBullet, x[i].transform.position, x[i].transform.rotation);
        //
        //  }
        //   //  GameObject seeker = Instantiate(seekerBullet, x[i].transform.position, x[i].transform.rotation);

        //  closestEnemy = closest;

        //  GameObject seeker = Instantiate(seekerBullet, closestEnemy.transform.position, closestEnemy.transform.rotation);


        // }

        GameObject[] x = GameObject.FindGameObjectsWithTag("Cube");
        float min_distance = 50f;

        for (int i = 0; i < x.Length; i++)
        {
            float distance = Vector3.Distance(x[i].transform.position, player.transform.position);
            if (distance < min_distance)
            {
                distance = min_distance;

                closest_enemy = x[i];
            }

            //  GameObject seeker = Instantiate(seekerBullet, closest_enemy.transform.position, closest_enemy.transform.rotation);
            // GameObject seeker = Instantiate(seekerBullet, closest_enemy.transform.position, Quaternion.identity);

        }


    }


}
