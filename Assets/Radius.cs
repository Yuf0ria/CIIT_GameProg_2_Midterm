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

    private void OnCollision(Collider other)
    {
        if (other.transform.tag == ("EnemyRed"))
        {
            shoot = other.GetComponent<PlayerFire>();
        }
        if (other.transform.tag == ("EnemyGreen"))
        {
            shoot = other.GetComponent<PlayerFire>();
        }
        if (other.transform.tag == ("EnemyBlue"))
        {
            shoot = other.GetComponent<PlayerFire>();
        }
    }
}
