using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{

    public Transform player;
    int MoveSpeed = 2;
    int MaxDist = 10;
    int MinDist = 5;




    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "bullet")
        Destroy(gameObject);
    }

    void Update()
    {
        transform.LookAt(player);

        if (Vector3.Distance(transform.position, player.position) >= MinDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;



            if (Vector3.Distance(transform.position, player.position) <= MaxDist)
            {
                //Here Call any function U want Like Shoot at here or something
            }

        }
    }
}