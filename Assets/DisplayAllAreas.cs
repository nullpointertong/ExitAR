using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayAllAreas : MonoBehaviour
{
    public GameObject floorPlan;
    public ArrayList children;

    // Start is called before the first frame update
    void Start()
    {
        floorPlan = new GameObject();
        children = new ArrayList();

        for (int i = 0; i < floorPlan.transform.childCount - 1; i++)
        {
            GameObject tempChild = floorPlan.transform.GetChild(i).gameObject;

            children.Add(tempChild);
        }
    }

    void ShowChildren()
    {
        // TODO: Add logic for showing the names of all the children of the floor plan.
    }
}
