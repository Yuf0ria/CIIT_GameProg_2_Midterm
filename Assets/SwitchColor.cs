using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchColor : MonoBehaviour
{
    public GameObject Player,CurrentPlayer;
    private void OnMouseDown()
    {
        Player.SetActive(true);
        CurrentPlayer.SetActive(false);
    }

}
