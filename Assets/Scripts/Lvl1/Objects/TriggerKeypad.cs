using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerKeypad : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject pokeInteractor;
 
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pokeInteractor.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pokeInteractor.SetActive(false);
        }
    }
}
