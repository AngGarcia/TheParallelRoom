using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using DG.Tweening;

public class chessPuzzle : MonoBehaviour
{
    [SerializeField] private GameObject pawn;

    [SerializeField] private GameObject socket1;
    [SerializeField] private GameObject socket2;

    private bool puzzlePassed = false;

    private IEnumerator resetPawnPosition()
    {
        puzzlePassed = false;
        yield return new WaitForSeconds(0.25f);

        socket2.GetComponent<XRSocketInteractor>().enabled = false;
        pawn.transform.DOLocalMove(Vector3.zero, 2.0f);

        yield return new WaitForSeconds(2.0f);
        socket2.GetComponent<XRSocketInteractor>().enabled = true;
    }

    //IEnumerator movePawn(float time)
    //{
    //    Vector3 startingPos = pawn.transform.position;
    //    Vector3 finalPos = respawnPosition.position;

    //    float elapsedTime = 0;
    //    while (elapsedTime < time)
    //    {
    //        //Debug.Log("ENTO");
    //        pawn.transform.position = Vector3.Lerp(startingPos, finalPos, (elapsedTime / time));
    //        elapsedTime += Time.deltaTime;
    //        yield return null;
    //    }
    //}

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
