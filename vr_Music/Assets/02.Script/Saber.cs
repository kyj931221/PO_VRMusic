using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saber : MonoBehaviour
{
    public LayerMask layer;

    Vector3 oldPos;

    private void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, 1, layer))
        {
            if(Vector3.Angle(transform.position - oldPos, hit.transform.up) > 140)
            {
                Destroy(hit.transform.gameObject);
            }
        }
        oldPos = transform.position;
    }
}
