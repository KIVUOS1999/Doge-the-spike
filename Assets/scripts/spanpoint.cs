using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spanpoint : MonoBehaviour
{
    public GameObject go;
    // Update is called once per frame
    void Start()
    {
        Instantiate(go, transform.position, Quaternion.identity);
    }
}
