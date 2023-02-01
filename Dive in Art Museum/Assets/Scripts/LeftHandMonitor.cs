using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LeftHandMonitor : MonoBehaviour
{
    public InputActionReference showAndHideMonitor;
    public GameObject monitor;
    public bool isHidden = true;

    private void OnEnable()
    {
        showAndHideMonitor.action.performed += ShowAndHide;
    }

    void ShowAndHide(InputAction.CallbackContext abc)
    {
        isHidden = !isHidden;
        monitor.SetActive(isHidden);
    }
}
