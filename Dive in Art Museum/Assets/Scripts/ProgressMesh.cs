using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressMesh : MonoBehaviour
{
    public int progressNumber = 1;
    public MeshRenderer[] progressMesh = new MeshRenderer[30];
    public GameObject fireworks;
    public GameObject finalPlane;
    public Transform SpawnTrans;
    public GameObject finalUI;

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
        //Debug.Log(progressMesh[progressNumber].gameObject.name);
        progressMesh[progressNumber].material.color = Color.green;

        progressNumber++;
        //Debug.Log(progressMesh[progressNumber].gameObject.name);

        if(progressNumber == 24)
        {
            Instantiate(fireworks, SpawnTrans);
            Instantiate(finalPlane, SpawnTrans);
            Invoke("ShowFinalUI", 10f);
        }
    }

    public void ShowFinalUI()
    {
        finalUI.SetActive(true);
    }
}
