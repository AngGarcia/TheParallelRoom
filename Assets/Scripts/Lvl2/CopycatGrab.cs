using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class CopycatGrab : MonoBehaviour
{
    [SerializeField] private GameObject menu1;
    [SerializeField] private GameObject menu2;
    [SerializeField] private InputActionProperty grabButton;
    [SerializeField] private Transform attachPoint;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Rigidbody>() != null)
        {
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }

        if (other.gameObject.GetComponent<GrabCheck>() != null)
        {
            other.gameObject.GetComponent<GrabCheck>().isBeingGrabbed = false;
        }  
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name != "LeftHandTriggerCollider" && other.gameObject.name != "RightHandTriggerCollider")
        {
            if (other.gameObject.GetComponent<GrabCheck>() != null && grabButton.action.IsPressed() && !menu1.activeSelf && !menu2.activeSelf)
            {
                other.gameObject.transform.position = attachPoint.position;
                other.gameObject.transform.rotation = attachPoint.rotation;
                if (other.gameObject.GetComponent<Rigidbody>() != null)
                {
                    other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                }

                other.gameObject.GetComponent<GrabCheck>().isBeingGrabbed = true;

            }

            if (other.gameObject.GetComponent<GrabCheck>() == null || !grabButton.action.IsPressed() || menu1.activeSelf || menu2.activeSelf)
            {
                if (other.gameObject.GetComponent<Rigidbody>() != null)
                {
                    other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                }

                if (other.gameObject.GetComponent<GrabCheck>() != null)
                {
                    other.gameObject.GetComponent<GrabCheck>().isBeingGrabbed = false;
                }
            }
        }
    }
}
