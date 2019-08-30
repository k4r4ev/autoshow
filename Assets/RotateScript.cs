using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateScript : MonoBehaviour
{
    private float ugol;    //угол поворота

    private bool IsRotate;   //для вращения

    void Start()
    {
        ugol = 1;
        IsRotate = false;
    }

    void Update()
    {
        if (IsRotate)
            transform.Rotate(Vector3.up, ugol);
    }

    public void Rotating()
    {
        if (IsRotate == true)
        {
            IsRotate = false;
        }
        else
        {
            IsRotate = true;
        }
    }

    public void leftRotate()
    {
        transform.Rotate(Vector3.up, 10*ugol);
    }

    public void rightRotate()
    {
        transform.Rotate(Vector3.up, -10*ugol);
    }
}
