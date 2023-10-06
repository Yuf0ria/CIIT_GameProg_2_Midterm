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

    private void OnCollision(Collider other)
    {
        if (other.transform.tag == ("Player"))
        {
            CanvasOn.SetActive(true);
        }
    }
}
