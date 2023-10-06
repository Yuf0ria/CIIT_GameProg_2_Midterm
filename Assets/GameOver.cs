using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CanvasOff, CanvasOn;
    void Start()
    {
        CanvasOff.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("EnemyRed"))
        {
            CanvasOn.SetActive(true);
        }
        else if (other.CompareTag("EnemyBlue"))
        {
            CanvasOn.SetActive(true);
        }
        else if (other.CompareTag("EnemyGreen"))
        {
            CanvasOn.SetActive(true);
        }
    }
}
