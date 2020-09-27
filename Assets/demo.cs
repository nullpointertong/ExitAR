using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public static class ButtonExtension {
    public static void AddEventListener<T> (this Button button, T param, Action<T> OnClick) {
        button.onClick.AddListener (delegate() {
            OnClick (param);
        });
    }
}

public class demo : MonoBehaviour {
    
    // Start is called before the first frame update
    void Start() {
        string[] array1 = new string[10] { 
            "CB 11.B2.403", 
            "CB 11.B2.404", 
            "CB 11.B2.405", 
            "CB 11.B2.406", 
            "CB 11.B2.407", 
            "Exit Broadway Level 00",
            "Exit Broadway Level 01",
            "Exit Broadway Level 02",
            "Exit Broadway Level 03",
            "Exit Broadway Level 04",
            };

        int[] arr = new int[5] {1, 10, 20, 30, 40};


       GameObject buttonTemplate = transform.GetChild (0).gameObject;
       GameObject g;

       for (int i = 0; i < array1.Length; i++) {
           g = Instantiate (buttonTemplate, transform);
           g.transform.GetChild (1).GetComponent <Text>().text = array1[i];
           g.GetComponent <Button>().AddEventListener (i, ItemClicked);
       }

       Destroy (buttonTemplate);
    }

    void ItemClicked(int index) {
        Debug.Log("Item " + index + " clicked");
    }

    // Update is called once per frame
    void Update() {
        
    }
}
