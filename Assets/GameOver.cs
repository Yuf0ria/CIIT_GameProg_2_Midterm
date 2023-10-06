using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Canvas, isTrigger, isTrigger1, isTrigger2;
    void Start()
    {
        Canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (isTrigger)
        {
            Canvas.SetActive(true);
        }
        else if (isTrigger1)
        {
            Canvas.SetActive(true);
        }
        else if (isTrigger2)
        {
            Canvas.SetActive(true);
        }
    }
}
