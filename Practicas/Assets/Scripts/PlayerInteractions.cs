using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
using UnityEngine.InputSystem;
#endif

#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
[RequireComponent(typeof(PlayerInput))]
#endif

public class PlayerInteractions : MonoBehaviour
{
    private StarterAssetsInputs _input;
    private Interactable _interactable;

    

    private void Start()
    {
        _input = GetComponent<StarterAssetsInputs>();
    }

    void Update()
    {
        if(_input.sprint && _interactable != null)
        {
       
            _interactable.Interact();
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Interactable"))
        {
            
            _interactable = other.GetComponent<Interactable>();
            Debug.Log("Me estas lastimando");

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Interactable"))
        {
           
            _interactable = null;
            Debug.Log("Ya no me estas lastimando, gracias");

        }
    }
    
}
