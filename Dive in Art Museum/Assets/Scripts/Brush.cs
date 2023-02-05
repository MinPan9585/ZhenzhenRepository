using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brush : MonoBehaviour
{
    public Color[] paintColors;
    public int index;
    public ProgressBar pb;
    public ProgressMesh pm;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Lines")
        {
            if (other.gameObject.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                //Debug.Log("add one scroe");
                pm.UpdateProgress();
            }
            index = Random.Range(0,5);
            other.gameObject.GetComponent<Renderer>().material.color = paintColors[index];
        }
    }
}
