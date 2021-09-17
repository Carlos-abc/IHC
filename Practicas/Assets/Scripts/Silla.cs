using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silla : Interactable
{
    public Vector3 rotationAxis;
    public override void Interact()
    {
        base.Interact();
        transform.Rotate(rotationAxis, 45f);

    }
}
