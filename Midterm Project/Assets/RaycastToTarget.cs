using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastToTarget : MonoBehaviour
{

    private int targetLayer = 1 << 8; // Layer 8 (targets)

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;

            // Parameters: position to start the ray, direction to project the ray, output for raycast, limit of ray length, and layer mask
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, targetLayer))
            {
                //Debug.Log(hit.collider.gameObject.name);
                Destroy(hit.collider.gameObject);
            }

        }
    }
}