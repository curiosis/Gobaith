using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{
    readonly DistanceJoint2D distanceJoint;
    readonly LineRenderer lineRenderer;
    Vector2 mousePos;

    public float distance;
    public LayerMask layerMaskRope;

    void Start()
    {
        distanceJoint.gameObject.GetComponent<DistanceJoint2D>();
        lineRenderer.gameObject.GetComponent<LineRenderer>();

        lineRenderer.enabled = false;
        distanceJoint.enabled = false;
    }

    void Update()
    {
        lineRenderer.SetPosition(0, transform.position);
        mousePos = GetMousePos();

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit2D raycastHit2D = Physics2D.Raycast(transform.position, mousePos, distance, layerMaskRope);

            if(raycastHit2D.collider != null)
            {
                distanceJoint.enabled = true;
                distanceJoint.connectedAnchor = raycastHit2D.point;

                lineRenderer.enabled = true;
                lineRenderer.SetPosition(1, raycastHit2D.point);
            }
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            distanceJoint.enabled = false;
            lineRenderer.enabled = false;
        }
    }

    Vector3 GetMousePos()
    {
        Vector3 mouseWorldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 mouseForwardPoint = mouseWorldPoint + (Camera.main.transform.forward * 10.0f);
        Vector3 direction = mouseForwardPoint - transform.position;
        return direction;
    }
}