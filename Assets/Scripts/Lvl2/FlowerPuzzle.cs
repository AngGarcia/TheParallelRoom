using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FlowerPuzzle : MonoBehaviour
{
    [SerializeField] private GameObject blueFlower;
    [SerializeField] private GameObject yellowFlower;
    [SerializeField] private GameObject redFlower;
    [SerializeField] private GameObject orangeFlower;

    [SerializeField] private GameObject blueSocket;
    [SerializeField] private GameObject yellowSocket;
    [SerializeField] private GameObject redSocket;
    [SerializeField] private GameObject orangeSocket;


    public int numToSolve = 4;
    public int numSolved = 0;
    public int toAddYellow = 0;
    public int toAddOrange = 0;
    public bool puzzlePassed = false;

    [SerializeField] private tableMarcos tableMarcos;

    public void winPuzzle()
    {
        StartCoroutine(win());
    }

    IEnumerator win()
    {
        yield return new WaitForSeconds(1.0f);
        puzzlePassed = true;
        blueFlower.GetComponent<XRGrabInteractable>().enabled = false;
        redFlower.GetComponent<XRGrabInteractable>().enabled = false;
        blueSocket.GetComponent<XRSocketInteractor>().enabled = false;
        yellowSocket.GetComponent<XRSocketInteractor>().enabled = false;
        redSocket.GetComponent<XRSocketInteractor>().enabled = false;
        orangeSocket.GetComponent<XRSocketInteractor>().enabled = false;

        blueFlower.GetComponent<Rigidbody>().isKinematic = true;
        yellowFlower.GetComponent<Rigidbody>().isKinematic = true;
        redFlower.GetComponent<Rigidbody>().isKinematic = true;
        orangeFlower.GetComponent<Rigidbody>().isKinematic = true;

        yellowFlower.GetComponent<GrabCheck>().enabled = false;
        orangeFlower.GetComponent<GrabCheck>().enabled = false;

        tableMarcos.unlockTableMarcos();
    }
}
