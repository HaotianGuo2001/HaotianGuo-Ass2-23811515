using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroManager : MonoBehaviour
{
    public GameObject hero;
    public float value;
    public Vector3 sizeChange;
    public void MoveLeft()
    {
        value = value - 1f;
        hero.transform.position = new Vector3(value, 0, 0);
    }
    public void RotateLeft()
    {
        hero.transform.Rotate(20f, 0f, 0f);
    }
    public void Grow()
    {
        hero.transform.localScale = hero.transform.localScale + sizeChange;
    }
    public void Resethero()
    {
        hero.transform.position = new Vector3(0, 0, 0);
        hero.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        hero.transform.localScale = new Vector3(1, 1, 1);
    }
}
