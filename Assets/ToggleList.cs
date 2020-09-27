using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleList : MonoBehaviour {

    public GameObject list;
    public GameObject input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static bool IsInputFieldFocused() {
        GameObject obj = EventSystem.current.currentSelectedGameObject;
        return (obj != null && obj.GetComponent<InputField>() != null);
    }
}
