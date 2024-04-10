using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinamiteSocket : MonoBehaviour
{
    [SerializeField]
    private GameObject[] tnt;

    private int numTnt = 0;
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "TNT")
        {
            numTnt++;
            other.gameObject.SetActive(false);
            for (int i = 0; i < numTnt; i++)
                tnt[i].gameObject.SetActive(true);
        }
    }

    public bool getNumTnt()
    {
        return (numTnt >= 3);
    }
}
