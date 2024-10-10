using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * 2;
    }
}
