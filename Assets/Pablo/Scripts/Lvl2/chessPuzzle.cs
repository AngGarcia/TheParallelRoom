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

    private IEnumerator resetPawnPosition(float time)
    {
        puzzlePassed = false;
        yield return new WaitForSeconds(0.25f);
        //pawn.transform.position = new Vector3(pawn.transform.position.x + addToRes, pawn.transform.position.y, pawn.transform.position.z);
        //pawn.transform.position = pawnPosition;
        StartCoroutine(movePawn(time));
        
    }

    IEnumerator movePawn(float time)
    {
        Vector3 startingPos = pawn.transform.position;
        Vector3 finalPos = pawnPosition;

        float elapsedTime = 0;

        while (elapsedTime < time)
        {
            //Debug.Log("ENTO");
            pawn.transform.position = Vector3.Lerp(startingPos, finalPos, (elapsedTime / time));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }

    public void losePuzzle()
    {

        StartCoroutine(resetPawnPosition(2.0f));
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
