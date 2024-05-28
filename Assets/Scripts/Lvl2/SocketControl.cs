using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketControl : MonoBehaviour
{
    private XRSocketInteractor socket;
    [SerializeField] private chessPuzzle puzzle;
    [SerializeField] private int squareType;
    [SerializeField] private int squareFilter;

    // Start is called before the first frame update
    void Start()
    {
        socket = GetComponent<XRSocketInteractor>();
    }

    public void SocketCheck()
    {
        GameObject item = socket.selectTarget.gameObject;
        if (item.CompareTag("Pawn") && squareType==0 && squareFilter==0)
        {
            item.GetComponent<Rigidbody>().isKinematic = true;
            socket.socketActive = false;
            
            StartCoroutine(resetSocket(item, 0));
        }
        else if(item.CompareTag("Pawn") && squareType==1 &&squareFilter==0)
        {
            puzzle.winPuzzle();
        }
        else if (item.CompareTag("Knight") && squareType == 0 && squareFilter == 1)
        {
            item.GetComponent<Rigidbody>().isKinematic = true;
            socket.socketActive = false;

            StartCoroutine(resetSocket(item, 1));
        }
        else if (item.CompareTag("Bishop1") && squareType == 0 && squareFilter == 2)
        {
            item.GetComponent<Rigidbody>().isKinematic = true;
            socket.socketActive = false;

            StartCoroutine(resetSocket(item, 2));
        }
        else if (item.CompareTag("Bishop2") && squareType == 0 && squareFilter == 3)
        {
            item.GetComponent<Rigidbody>().isKinematic = true;
            socket.socketActive = false;

            StartCoroutine(resetSocket(item, 3));
        }
        else if (item.CompareTag("King") && squareType == 0 && squareFilter == 4)
        {
            item.GetComponent<Rigidbody>().isKinematic = true;
            socket.socketActive = false;

            StartCoroutine(resetSocket(item, 4));
        }

    }

    IEnumerator resetSocket(GameObject item, int resetType)
    {
        yield return new WaitForSeconds(0.5f);
        puzzle.losePuzzle(resetType);
        item.GetComponent<Rigidbody>().isKinematic = false;
        socket.socketActive = true;
    }

}
