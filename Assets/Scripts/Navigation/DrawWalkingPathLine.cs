using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawWalkingPathLine : MonoBehaviour
{
    public LineRenderer walkingPath;
    private Vector3[] positions = null;

    public Camera cam;

    public float waitTime = 5;

    int nodeIndex = 0;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        int numVertices = walkingPath.positionCount;

        positions = new Vector3[numVertices];

        walkingPath.GetPositions(positions);

        Debug.Log(positions);

        while (true)
        {
            yield return new WaitForSeconds(waitTime);

            UpdateWalkingPath();
        }
    }

    void UpdateWalkingPath()
    {
        Vector3 farthestNode = new Vector3(0, 0, 0);

        Vector3 node = walkingPath.GetPosition(nodeIndex);
        Vector3 nextNode = walkingPath.GetPosition(nodeIndex + 1);

        Vector3 pos = cam.transform.position;

        pos = nextNode;
        pos.x += 1;
        pos.y = 7;

        cam.transform.position = pos;

        nodeIndex++;
    }


    // Update is called once per frame
    void Update()
    {
        // Check if route has been updated

        // If Routed updated, redraw the Route

        // Else return
    }
}
