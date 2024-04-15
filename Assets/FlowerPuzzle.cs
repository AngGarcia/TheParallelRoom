using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FlowerPuzzle : MonoBehaviour
{
    public GameObject blueFlower;
    public GameObject yellowFlower;
    public GameObject redFlower;
    public GameObject orangeFlower;


    public GameObject blueSocket;
    public GameObject yellowSocket;
    public GameObject redSocket;
    public GameObject orangeSocket;


    public int numToSolve = 4;
    public int numSolved = 0;
    public bool puzzlePassed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void winPuzzle()
    {
        Debug.Log("FLOWER PUZZLE PASSED");
        puzzlePassed = true;
        blueFlower.GetComponent<XRGrabInteractable>().enabled = false;
        yellowFlower.GetComponent<XRGrabInteractable>().enabled = false;
        redFlower.GetComponent<XRGrabInteractable>().enabled = false;
        orangeFlower.GetComponent<XRGrabInteractable>().enabled = false;
        //Deshabilitar sockets?
        blueSocket.GetComponent<XRSocketInteractor>().enabled = false;
        yellowSocket.GetComponent<XRSocketInteractor>().enabled = false;
        redSocket.GetComponent<XRSocketInteractor>().enabled = false;
        orangeSocket.GetComponent<XRSocketInteractor>().enabled = false;

        blueFlower.GetComponent<Rigidbody>().isKinematic = true;
        yellowFlower.GetComponent<Rigidbody>().isKinematic = true;
        redFlower.GetComponent<Rigidbody>().isKinematic = true;
        orangeFlower.GetComponent<Rigidbody>().isKinematic = true;
    }
}
