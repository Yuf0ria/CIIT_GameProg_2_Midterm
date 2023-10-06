using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionTest : MonoBehaviour
{
    public List<Color> color;
    public MeshRenderer mat;

    void Start()
    {
        mat = GetComponent<MeshRenderer>();
    }
    private void OnEnable()
    {
        //ChangeColor();
    }
    private void OnDisable()
    {
        //ChangeColor();
    }

    private void OnMouseDown()
    {
        ChangeColor();
        //Invoke(nameof(ChangeColor),5);
        //InvokeRepeating(nameof(ChangeColor),2,.5f);
    } 
    private void OnMouseDrag()
    {
        //ChangeColor();
    }
    private void OnMouseEnter()
    {
        //ChangeColor();
    }
    private void OnMouseExit()
    {
        //ChangeColor();
    }

    private void OnMouseOver()
    {
        //ChangeColor();
    } 
    private void OnMouseUpAsButton()
    {
        //ChangeColor();
    }

    public void ChangeColor()
    {

        for (int i = 0; i < color.Count; i++)
        {
            mat.material.color = color[Random.Range(0, color.Count)];
        }
    }
}
