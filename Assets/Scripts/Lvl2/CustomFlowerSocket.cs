using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CustomFlowerSocket : MonoBehaviour
{
    [SerializeField] private Transform AttachPoint;
    [SerializeField] private FlowerPuzzle puzzle;

    //Yellow = 1
    //Orange = 3
    [SerializeField] private int vaseType;

    private bool yellowCheck = false;
    private bool orangeCheck = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "YellowFlower" && !other.gameObject.GetComponent<GrabCheck>().isBeingGrabbed/*!grabButtonLeft.action.IsPressed() && !grabButtonRight.action.IsPressed()*/)
        {
            other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            other.gameObject.transform.position = AttachPoint.position;
            other.gameObject.transform.rotation = AttachPoint.rotation;
            if (vaseType==1 && !yellowCheck)
            {
                yellowCheck = true;
                puzzle.toAddYellow = 1;
                if ((puzzle.numSolved + puzzle.toAddYellow + puzzle.toAddOrange) >= puzzle.numToSolve)
                {
                    puzzle.winPuzzle();
                }
            }
        }

        if(other.gameObject.tag == "OrangeFlower" && !other.gameObject.GetComponent<GrabCheck>().isBeingGrabbed/*!grabButtonLeft.action.IsPressed() && !grabButtonRight.action.IsPressed()*/)
        {
            other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            other.gameObject.transform.position = AttachPoint.position;
            other.gameObject.transform.rotation = AttachPoint.rotation;
            if (vaseType == 3 && !orangeCheck)
            {
                orangeCheck = true;
                puzzle.toAddOrange = 1;
                if ((puzzle.numSolved + puzzle.toAddYellow + puzzle.toAddOrange) >= puzzle.numToSolve)
                {
                    puzzle.winPuzzle();
                }
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "YellowFlower" && !other.gameObject.GetComponent<GrabCheck>().isBeingGrabbed/*!grabButtonLeft.action.IsPressed() && !grabButtonRight.action.IsPressed()*/)
        {
            other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            other.gameObject.transform.position = AttachPoint.position;
            other.gameObject.transform.rotation = AttachPoint.rotation;
            if (vaseType == 1 && !yellowCheck)
            {
                yellowCheck = true;
                puzzle.toAddYellow = 1;
                if ((puzzle.numSolved + puzzle.toAddYellow + puzzle.toAddOrange) >= puzzle.numToSolve)
                {
                    puzzle.winPuzzle();
                }
            }
        }

        if (other.gameObject.tag == "OrangeFlower" && !other.gameObject.GetComponent<GrabCheck>().isBeingGrabbed/*!grabButtonLeft.action.IsPressed() && !grabButtonRight.action.IsPressed()*/)
        {
            other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            other.gameObject.transform.position = AttachPoint.position;
            other.gameObject.transform.rotation = AttachPoint.rotation;
            if (vaseType == 3 && !orangeCheck)
            {
                orangeCheck = true;
                puzzle.toAddOrange = 1;
                if ((puzzle.numSolved + puzzle.toAddYellow + puzzle.toAddOrange) >= puzzle.numToSolve)
                {
                    puzzle.winPuzzle();
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "YellowFlower")
        {
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            yellowCheck = false;
            puzzle.toAddYellow = 0;
        }

        if (other.gameObject.tag == "OrangeFlower")
        {
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            orangeCheck = false;
            puzzle.toAddOrange = 0;
        }
    }
}
