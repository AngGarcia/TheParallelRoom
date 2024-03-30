using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerKeypad : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject pokeInteractor;
    [SerializeField]
    private BoxCollider controllerCollider;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pokeInteractor.SetActive(true);
            controllerCollider.enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pokeInteractor.SetActive(false);
            controllerCollider.enabled = true;
        }
    }
}
