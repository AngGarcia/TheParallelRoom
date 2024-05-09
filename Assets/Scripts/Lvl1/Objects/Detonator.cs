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
    [SerializeField]
    private GameObject socket;
    [SerializeField]
    private GameObject explosion;

    [SerializeField]
    private GameObject compartimentoTNT;
    [SerializeField]
    private GameObject cable;
    [SerializeField]
    private GameObject TNT1;
    [SerializeField]
    private GameObject TNT2;
    [SerializeField]
    private GameObject TNT3;


    private void Start()
    {
        explosion.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Lever" && DinamiteSocket.getNumTnt() && tape.isCableFixed())
        {
            rocks.SetActive(false);
            socket.SetActive(false);
            Debug.Log("Exploooooooooooooooooooosion");
            explosion.SetActive(true);

            compartimentoTNT.GetComponent<MeshRenderer>().enabled = false;
            cable.GetComponent<MeshRenderer>().enabled = false;
            TNT1.SetActive(false);
            TNT2.SetActive(false);
            TNT3.SetActive(false);
        }
    }
}
