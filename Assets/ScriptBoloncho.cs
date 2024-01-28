using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBoloncho : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody rb;



    void Start()
    {
        rb.velocity = Vector3.forward * speed * -1;
    }
}
