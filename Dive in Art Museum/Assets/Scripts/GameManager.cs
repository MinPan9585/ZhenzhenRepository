using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    void Start()
    {
        Invoke("ShowUI", 6f);
        Invoke("ShowSecondUI", 12f);
        Invoke("HideUI", 18f);
    }


    public void ShowUI()
    {
        panel1.SetActive(true);
    }

    public void ShowSecondUI()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
    }

    public void HideUI()
    {
        panel2.SetActive(false);
    }
}
