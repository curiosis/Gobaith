using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{
    public DistanceJoint2D distanceJoint;
    public Camera mainCamera;
    public LineRenderer lineRenderer;

    Vector2 mousePos;

    void Start()
    {
        distanceJoint.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            mousePos = GetMousePos();
            lineRenderer.SetPosition(0, mousePos);
            lineRenderer.SetPosition(1, transform.position);
            distanceJoint.connectedAnchor = mousePos;
            distanceJoint.enabled = true;
            lineRenderer.enabled = true;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            distanceJoint.enabled = false;
            lineRenderer.enabled = false;
        }

        if (distanceJoint.enabled)
            lineRenderer.SetPosition(1, transform.position);
            
    }

    Vector2 GetMousePos()
    {
        return mainCamera.ScreenToWorldPoint(Input.mousePosition);
    }
}
