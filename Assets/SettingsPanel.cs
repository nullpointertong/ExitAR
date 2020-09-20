using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class SettingsPanel : MonoBehaviour
{
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
    }

    public void ToggleRender()
    {
        rend.enabled = true;
    }
}
