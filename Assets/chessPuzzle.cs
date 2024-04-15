using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class chessPuzzle : MonoBehaviour
{
    public GameObject pawn;
    private Transform respawnPosition;
    public Vector3 pawnPosition;

    public GameObject socket1;
    public GameObject socket2;
    //public float addToRes = -0.1f;

    //0=NOTHING
    //1=LOSE
    //2=WIN
    public bool puzzlePassed = false;
    // Start is called before the first frame update
    void Start()
    {
        respawnPosition = pawn.transform;
        //pawnPosition = respawnPosition.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator resetPawnPosition()
    {
        puzzlePassed = false;
        yield return new WaitForSeconds(0.25f);
        //pawn.transform.position = new Vector3(pawn.transform.position.x + addToRes, pawn.transform.position.y, pawn.transform.position.z);
        pawn.transform.position = pawnPosition;
    }

    public void losePuzzle()
    {

        StartCoroutine(resetPawnPosition());
    }

    public void winPuzzle()
    {
        puzzlePassed = true;
        pawn.GetComponent<XRGrabInteractable>().enabled = false;
        //Deshabilitar sockets?
        socket1.GetComponent<XRSocketInteractor>().enabled = false;
        socket2.GetComponent<XRSocketInteractor>().enabled = false;
    }

}
