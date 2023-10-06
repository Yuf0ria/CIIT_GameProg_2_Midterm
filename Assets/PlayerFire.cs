using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public Transform spawnBulletHere;
    public GameObject bulletPrefab;
    //float Variable of speed bullet
    public float bulletSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))//left mouse button is clicked
        {
            shoot();
        }
    }

    void shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, spawnBulletHere.position, spawnBulletHere.rotation);
        Rigidbody bulletRB = bullet.GetComponent<Rigidbody>();

        bulletRB.AddForce(spawnBulletHere.forward * bulletSpeed, ForceMode.Impulse);
    }
}
