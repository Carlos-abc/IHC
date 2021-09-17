using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carreola : Interactable
{
    public Vector3 forceVector;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public override void Interact()
    {
        base.Interact();
        rb.AddForce(forceVector, ForceMode.Force);
    }
}
