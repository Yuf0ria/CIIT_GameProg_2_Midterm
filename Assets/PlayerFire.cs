using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public Transform spawnBulletHere;
    public GameObject bulletPrefab;
    //float Variable of speed bullet
    public float bulletSpeed;
    public float fireRate = 5;
    //base firerate
    private float BaseFireRate;
    //public EnemyHandler
    // Start is called before the first frame update
    void Start()
    {
        BaseFireRate = fireRate;
    }

    // Update is called once per frame
    void Update()
    {
        fireRate -= Time.deltaTime;
        if ( fireRate <= 0 )
        {
            shoot();
        }
        
    }

    void shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, spawnBulletHere.position, spawnBulletHere.rotation);
        Rigidbody bulletRB = bullet.GetComponent<Rigidbody>();

        bulletRB.AddForce(spawnBulletHere.forward * bulletSpeed, ForceMode.Impulse);
        fireRate = BaseFireRate;
    }
}
