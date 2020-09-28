using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using UnityEngine;

public class PanelRenderToggle : MonoBehaviour
{
    private GameObject panel;

    void Start()
    {
        //panel = new GameObject();
        panel.SetActive(true);
    }

    public void ToggleRender()
    {
        panel.SetActive(false);
    }
}
