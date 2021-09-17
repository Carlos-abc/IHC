using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private bool zonaIterativa = false;

    public virtual void Interact()
    {
        Debug.Log("Interactuando");
     
    }

    private void Update()
    {
        if(zonaIterativa && Input.GetKeyDown(KeyCode.K))
        {
            Interact();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            zonaIterativa = true;
            Debug.Log("Me estas lastimando");

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            zonaIterativa = false;
            Debug.Log("Ya no me estas lastimando, gracias");

        }
    }


}
