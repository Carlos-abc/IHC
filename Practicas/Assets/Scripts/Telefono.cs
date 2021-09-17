using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telefono : Interactable
{
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    public override void Interact()
    {
        base.Interact();
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
