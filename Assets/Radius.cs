using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radius : MonoBehaviour
{
    // Start is called before the first frame update
    public float radius;
    public PlayerFire shoot;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
       Gizmos.color = Color.red;
       Gizmos.DrawWireSphere(transform.position, radius);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EnemyRed"))
        {
            shoot = other.GetComponent<PlayerFire>();
        }
        if (other.CompareTag("EnemyBlue"))
        {
            shoot = other.GetComponent<PlayerFire>();

        }
        if (other.CompareTag("EnemyGreen"))
        {
            shoot = other.GetComponent<PlayerFire>();

        }
    }
}
