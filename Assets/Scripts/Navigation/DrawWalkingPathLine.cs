using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawWalkingPathLine : MonoBehaviour
{
    public LineRenderer walkingPath;
    private Vector3[] positions = null;
    public Camera cam;

    public int numPointsToDisplay = 4;
    private Vector3[] displayPositions = null;

    private int numVertices = 13;

    public float waitTime = 7;
    int nodeIndex = 1;

    private float startX = 0;
    private float startZ = 0;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        positions = new Vector3[numVertices];
        displayPositions = new Vector3[numPointsToDisplay];

        walkingPath.GetPositions(positions);

        walkingPath.positionCount = displayPositions.Length;

        startX = walkingPath.GetPosition(0).x;
        startZ = walkingPath.GetPosition(0).z;

        displayPositions[0].x = startX;
        displayPositions[0].y = 7;
        displayPositions[0].z = startZ;

        while (true)
        {
            yield return new WaitForSeconds(waitTime);

            UpdateDisplayPathNodes();
        }
    }

    void UpdateDisplayPathNodes()
    {
        // copy sub into display
        for (int i = 1; i < displayPositions.Length; i++, nodeIndex++)
        {
            displayPositions[i] = positions[nodeIndex];
        }

        float offsetX = displayPositions[0].x - displayPositions[1].x;
        float offsetZ = displayPositions[0].z - displayPositions[1].z;

        for (int i = 1; i < displayPositions.Length; i++)
        {
            displayPositions[i].x += offsetX;
            displayPositions[i].z += offsetZ;
        }

        walkingPath.SetPositions(displayPositions);
        Debug.Log("Updating");
    }
}
