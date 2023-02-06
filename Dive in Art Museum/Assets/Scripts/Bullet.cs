using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public Color[] paintColors;
    public int index;
    //public ProgressBar pb;
    public ProgressMesh pm;

    private void Start()
    {
        pm = GameObject.FindObjectOfType<ProgressMesh>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Lines")
        {
            if(other.gameObject.GetComponent<MeshRenderer>().material.color == Color.white)
            {
                pm.UpdateProgress();
                //pb.progress += 0.0333f;
                //pb.progressImage.fillAmount = pb.progress;
            }
            index = Random.Range(0, 4);
            other.gameObject.GetComponent<Renderer>().material.color = paintColors[index];
        }
    }
}
