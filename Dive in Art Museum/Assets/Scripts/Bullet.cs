using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public Color[] paintColors;
    public int index;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Lines")
        {
            index = Random.Range(0, 4);
            other.gameObject.GetComponent<Renderer>().material.color = paintColors[index];
        }
    }
}
