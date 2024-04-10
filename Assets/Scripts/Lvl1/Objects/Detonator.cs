using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detonator : MonoBehaviour
{
    [SerializeField]
    private DinamiteSocket DinamiteSocket;
    [SerializeField]
    private Tape tape;
    [SerializeField]
    private GameObject rocks;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Lever" && DinamiteSocket.getNumTnt() && tape.isCableFixed())
        {
            rocks.SetActive(false);
            Debug.Log("Exploooooooooooooooooooosion");
        }
    }
}
