using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerKeypad : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject pokeInteractor1;
    [SerializeField]
    private GameObject pokeInteractor2;
    //[SerializeField]
    // private BoxCollider controllerCollider;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pokeInteractor1.SetActive(true);
            pokeInteractor2.SetActive(true);
            //controllerCollider.enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pokeInteractor1.SetActive(false);
            pokeInteractor2.SetActive(false);
            //controllerCollider.enabled = true;
            other.gameObject.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
