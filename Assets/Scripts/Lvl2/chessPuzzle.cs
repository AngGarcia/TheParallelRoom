using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using DG.Tweening;

public class chessPuzzle : MonoBehaviour
{
    [SerializeField] private GameObject pawn;
    [SerializeField] private GameObject knight;
    [SerializeField] private GameObject bishop1;
    [SerializeField] private GameObject bishop2;
    [SerializeField] private GameObject king;

    //Sockets del peón
    [SerializeField] private GameObject socket1; //el bueno
    [SerializeField] private GameObject socket2;

    //Sockets del caballo
    [SerializeField] private GameObject socket3;
    [SerializeField] private GameObject socket4;
    [SerializeField] private GameObject socket5;
    [SerializeField] private GameObject socket6;
    [SerializeField] private GameObject socket7;
    [SerializeField] private GameObject socket8;

    //Sockets del alfil 1
    [SerializeField] private GameObject socket9;
    [SerializeField] private GameObject socket10;
    [SerializeField] private GameObject socket11;
    [SerializeField] private GameObject socket12;
    [SerializeField] private GameObject socket13;
    [SerializeField] private GameObject socket14;
    [SerializeField] private GameObject socket15;
    [SerializeField] private GameObject socket16;
    [SerializeField] private GameObject socket17;

    //Sockets del alfil 2
    [SerializeField] private GameObject socket18;
    [SerializeField] private GameObject socket19;
    [SerializeField] private GameObject socket20;
    [SerializeField] private GameObject socket21;
    [SerializeField] private GameObject socket22;
    [SerializeField] private GameObject socket23;
    [SerializeField] private GameObject socket24;
    [SerializeField] private GameObject socket25;
    [SerializeField] private GameObject socket26;

    //Sockets del rey
    [SerializeField] private GameObject socket27;
    [SerializeField] private GameObject socket28;
    [SerializeField] private GameObject socket29;
    [SerializeField] private GameObject socket30;

    [SerializeField] private Vector3 knightInitialPos;
    [SerializeField] private Vector3 bishop1InitialPos;
    [SerializeField] private Vector3 bishop2InitialPos;
    [SerializeField] private Vector3 kingInitialPos;

    [SerializeField] private unlockCupboardDoors cupboardDoors;

    [SerializeField] private bool puzzlePassed = false;

    private void Start()
    {
        knightInitialPos = knight.transform.localPosition;
        bishop1InitialPos = bishop1.transform.localPosition;
        bishop2InitialPos = bishop2.transform.localPosition;
        kingInitialPos = king.transform.localPosition;

    }

    private IEnumerator resetPawnPosition(int resetType)
    {
        puzzlePassed = false;
        yield return new WaitForSeconds(0.25f);

        //reset peón
        if(resetType == 0)
        {
            socket2.GetComponent<XRSocketInteractor>().enabled = false;
            pawn.transform.DOLocalMove(Vector3.zero, 2.0f);

            yield return new WaitForSeconds(2.0f);
            socket2.GetComponent<XRSocketInteractor>().enabled = true;
        }
        //reset caballo
        else if(resetType == 1)
        {
            socket3.GetComponent<XRSocketInteractor>().enabled = false;
            socket4.GetComponent<XRSocketInteractor>().enabled = false;
            socket5.GetComponent<XRSocketInteractor>().enabled = false;
            socket6.GetComponent<XRSocketInteractor>().enabled = false;
            socket7.GetComponent<XRSocketInteractor>().enabled = false;
            socket8.GetComponent<XRSocketInteractor>().enabled = false;
            knight.transform.DOLocalMove(knightInitialPos, 2.0f);

            yield return new WaitForSeconds(2.0f);
            socket3.GetComponent<XRSocketInteractor>().enabled = true;
            socket4.GetComponent<XRSocketInteractor>().enabled = true;
            socket5.GetComponent<XRSocketInteractor>().enabled = true;
            socket6.GetComponent<XRSocketInteractor>().enabled = true;
            socket7.GetComponent<XRSocketInteractor>().enabled = true;
            socket8.GetComponent<XRSocketInteractor>().enabled = true;
        }
        //reset alfil1
        else if(resetType == 2)
        {
            socket9.GetComponent<XRSocketInteractor>().enabled = false;
            socket10.GetComponent<XRSocketInteractor>().enabled = false;
            socket11.GetComponent<XRSocketInteractor>().enabled = false;
            socket12.GetComponent<XRSocketInteractor>().enabled = false;
            socket13.GetComponent<XRSocketInteractor>().enabled = false;
            socket14.GetComponent<XRSocketInteractor>().enabled = false;
            socket15.GetComponent<XRSocketInteractor>().enabled = false;
            socket16.GetComponent<XRSocketInteractor>().enabled = false;
            socket17.GetComponent<XRSocketInteractor>().enabled = false;
            bishop1.transform.DOLocalMove(bishop1InitialPos, 2.0f);

            yield return new WaitForSeconds(2.0f);
            socket9.GetComponent<XRSocketInteractor>().enabled = true;
            socket10.GetComponent<XRSocketInteractor>().enabled = true;
            socket11.GetComponent<XRSocketInteractor>().enabled = true;
            socket12.GetComponent<XRSocketInteractor>().enabled = true;
            socket13.GetComponent<XRSocketInteractor>().enabled = true;
            socket14.GetComponent<XRSocketInteractor>().enabled = true;
            socket15.GetComponent<XRSocketInteractor>().enabled = true;
            socket16.GetComponent<XRSocketInteractor>().enabled = true;
            socket17.GetComponent<XRSocketInteractor>().enabled = true;
        }
        //reset alfil2
        else if (resetType == 3)
        {
            socket18.GetComponent<XRSocketInteractor>().enabled = false;
            socket19.GetComponent<XRSocketInteractor>().enabled = false;
            socket20.GetComponent<XRSocketInteractor>().enabled = false;
            socket21.GetComponent<XRSocketInteractor>().enabled = false;
            socket22.GetComponent<XRSocketInteractor>().enabled = false;
            socket23.GetComponent<XRSocketInteractor>().enabled = false;
            socket24.GetComponent<XRSocketInteractor>().enabled = false;
            socket25.GetComponent<XRSocketInteractor>().enabled = false;
            socket26.GetComponent<XRSocketInteractor>().enabled = false;
            bishop2.transform.DOLocalMove(bishop2InitialPos, 2.0f);

            yield return new WaitForSeconds(2.0f);
            socket18.GetComponent<XRSocketInteractor>().enabled = true;
            socket19.GetComponent<XRSocketInteractor>().enabled = true;
            socket20.GetComponent<XRSocketInteractor>().enabled = true;
            socket21.GetComponent<XRSocketInteractor>().enabled = true;
            socket22.GetComponent<XRSocketInteractor>().enabled = true;
            socket23.GetComponent<XRSocketInteractor>().enabled = true;
            socket24.GetComponent<XRSocketInteractor>().enabled = true;
            socket25.GetComponent<XRSocketInteractor>().enabled = true;
            socket26.GetComponent<XRSocketInteractor>().enabled = true;
        }
        //reset rey
        else if (resetType == 4)
        {
            socket27.GetComponent<XRSocketInteractor>().enabled = false;
            socket28.GetComponent<XRSocketInteractor>().enabled = false;
            socket29.GetComponent<XRSocketInteractor>().enabled = false;
            socket30.GetComponent<XRSocketInteractor>().enabled = false;
            king.transform.DOLocalMove(kingInitialPos, 2.0f);

            yield return new WaitForSeconds(2.0f);
            socket27.GetComponent<XRSocketInteractor>().enabled = true;
            socket28.GetComponent<XRSocketInteractor>().enabled = true;
            socket29.GetComponent<XRSocketInteractor>().enabled = true;
            socket30.GetComponent<XRSocketInteractor>().enabled = true;
        }

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

    public void losePuzzle(int resetType)
    {
        StartCoroutine(resetPawnPosition(resetType));
    }

    public void winPuzzle()
    {
        puzzlePassed = true;
        pawn.GetComponent<XRGrabInteractable>().enabled = false;
        knight.GetComponent<XRGrabInteractable>().enabled = false;
        bishop1.GetComponent<XRGrabInteractable>().enabled = false;
        bishop2.GetComponent<XRGrabInteractable>().enabled = false;
        king.GetComponent<XRGrabInteractable>().enabled = false;
        //Deshabilitar sockets?
        socket1.GetComponent<XRSocketInteractor>().enabled = false;
        socket2.GetComponent<XRSocketInteractor>().enabled = false;
        socket3.GetComponent<XRSocketInteractor>().enabled = false;
        socket4.GetComponent<XRSocketInteractor>().enabled = false;
        socket5.GetComponent<XRSocketInteractor>().enabled = false;
        socket6.GetComponent<XRSocketInteractor>().enabled = false;
        socket7.GetComponent<XRSocketInteractor>().enabled = false;
        socket8.GetComponent<XRSocketInteractor>().enabled = false;
        socket9.GetComponent<XRSocketInteractor>().enabled = false;
        socket10.GetComponent<XRSocketInteractor>().enabled = false;
        socket11.GetComponent<XRSocketInteractor>().enabled = false;
        socket12.GetComponent<XRSocketInteractor>().enabled = false;
        socket13.GetComponent<XRSocketInteractor>().enabled = false;
        socket14.GetComponent<XRSocketInteractor>().enabled = false;
        socket15.GetComponent<XRSocketInteractor>().enabled = false;
        socket16.GetComponent<XRSocketInteractor>().enabled = false;
        socket17.GetComponent<XRSocketInteractor>().enabled = false;
        socket18.GetComponent<XRSocketInteractor>().enabled = false;
        socket19.GetComponent<XRSocketInteractor>().enabled = false;
        socket20.GetComponent<XRSocketInteractor>().enabled = false;
        socket21.GetComponent<XRSocketInteractor>().enabled = false;
        socket22.GetComponent<XRSocketInteractor>().enabled = false;
        socket23.GetComponent<XRSocketInteractor>().enabled = false;
        socket24.GetComponent<XRSocketInteractor>().enabled = false;
        socket25.GetComponent<XRSocketInteractor>().enabled = false;
        socket26.GetComponent<XRSocketInteractor>().enabled = false;
        socket27.GetComponent<XRSocketInteractor>().enabled = false;
        socket28.GetComponent<XRSocketInteractor>().enabled = false;
        socket29.GetComponent<XRSocketInteractor>().enabled = false;
        socket30.GetComponent<XRSocketInteractor>().enabled = false;

        cupboardDoors.unlockDoors();
    }


}
