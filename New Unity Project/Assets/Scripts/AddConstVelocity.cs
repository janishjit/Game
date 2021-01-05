using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddConstVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 v3force;

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity += v3force;
    }
}
