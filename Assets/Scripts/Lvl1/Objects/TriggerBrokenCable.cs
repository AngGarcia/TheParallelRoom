using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBrokenCable : MonoBehaviour
{
    
    public int cablePack;
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tape"))
        {
            other.gameObject.GetComponent<Tape>().canBeFixed();
            other.gameObject.GetComponent<Tape>().stateCable(cablePack);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Tape"))
        {
            other.gameObject.GetComponent<Tape>().canNotBeFixed();
        }
    }
}
