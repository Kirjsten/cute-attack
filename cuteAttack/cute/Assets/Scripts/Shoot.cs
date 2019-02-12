using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{
    public float bulletSpeed = 10;
    public Rigidbody bullet;
    public AudioClip mewClip;
    public AudioClip shotClip;
    //public AudioSource mewSource;
    //public AudioSource shotSource;

    private void Start()
    {
        //mewSource.clip = mewClip;
        //shotSource.clip = shotClip;
    }

    void Fire()
    {
        Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, transform.position, transform.rotation);
        bulletClone.velocity = transform.forward * bulletSpeed;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Fire();
    }

    private void OnTriggerEnter(Collider other)
    {
        //mewSource.Play();
        Destroy(this.gameObject);
    }
}