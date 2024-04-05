using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChangeCrate : MonoBehaviour
{
    [SerializeField]
    private GameObject objectInside;

    private bool abierto = false;

    //[SerializeField]
    // private GameObject gravel;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Crowbar"))
        {
            Debug.Log("Abierto");
            if (!abierto)
            {
                //objectInside.SetActive(true);
                this.GameObject().SetActive(false);
                objectInside.SetActive(true);
            }
        }
    }
}
