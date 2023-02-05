using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressMesh : MonoBehaviour
{
    public int progressNumber = 1;
    public MeshRenderer[] progressMesh = new MeshRenderer[30];

    void Start()
    {
        progressMesh = transform.GetComponentsInChildren<MeshRenderer>();
        //foreach(MeshRenderer var in progressMesh)
        //{
        //    Debug.Log(var.gameObject.name);
        //}
        
    }

    public void UpdateProgress()
    {
        Debug.Log(progressMesh[progressNumber].gameObject.name);
        progressMesh[progressNumber].material.color = Color.green;

        progressNumber++;
        Debug.Log(progressMesh[progressNumber].gameObject.name);
    }
}
