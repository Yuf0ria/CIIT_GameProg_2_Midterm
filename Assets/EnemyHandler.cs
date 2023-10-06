using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyHandler : MonoBehaviour
{
    public float speed = 0.25f;
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        // Create and position the cylinder. Reduce the size.
        var cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder.transform.localScale = new Vector3(0.15f, 1.0f, 0.15f);
        // Grab cylinder values and place on the target.
        target = cylinder.transform;
        target.transform.position = new Vector3(-0.01f, 0.9218f, -0.2143f);
    }

        // Update is called once per frame
    void Update()
    {
        // Move our position a step closer to the target.
        var step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position,
        target.position, step);
        // Check if the position of the cube and sphere are approximately equal.
        if (Vector3.Distance(transform.position, target.position) < 0.001f)
        {
            // Swap the position of the cylinder.
            target.position *= -1.0f;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("RedBullet"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        if (other.CompareTag("GreenBullet"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

        }
        if (other.CompareTag("BlueBullet"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

        }
    }
}
