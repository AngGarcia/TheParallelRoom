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
        for (int i = 0; i < numTnt; i++)
            if (other.tag == "TNT")
            {
                tnt[i].gameObject.SetActive(true);
                other.gameObject.SetActive(false);
            }

        numTnt++;
    }

    public int getNumTnt()
    {
        return numTnt;
    }
}
