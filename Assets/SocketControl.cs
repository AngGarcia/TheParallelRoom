using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketControl : MonoBehaviour
{
    public XRSocketInteractor socket;
    public chessPuzzle puzzle;
    public int squareType;

    // Start is called before the first frame update
    void Start()
    {
        socket = GetComponent<XRSocketInteractor>();
    }

    public void SocketCheck()
    {
        GameObject item = socket.selectTarget.gameObject;
        if (item.CompareTag("Pawn") && squareType==0)
        {
            //Debug.Log("ENTRO");
            //item.GetComponent<XRGrabInteractable>().
            item.GetComponent<Rigidbody>().isKinematic = true;
            socket.socketActive = false;
            
            StartCoroutine(resetSocket(item));
            //socket.socketActive = true;
        }
        else if(item.CompareTag("Pawn") && squareType==1)
        {
            puzzle.winPuzzle();
        }
    }

    IEnumerator resetSocket(GameObject item)
    {
        yield return new WaitForSeconds(0.5f);
        puzzle.losePuzzle();
        item.GetComponent<Rigidbody>().isKinematic = false;
        socket.socketActive = true;
    }

}
