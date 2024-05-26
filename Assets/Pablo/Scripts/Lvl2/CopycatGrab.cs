using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class CopycatGrab : MonoBehaviour
{
    public GameObject menu1;
    public GameObject menu2;
    public InputActionProperty grabButton;
    public Transform attachPoint;
    private bool mayGrab;
    // Start is called before the first frame update
    void Start()
    {
        //mayGrab = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       // mayGrab=true;
        //if (other.gameObject.GetComponent<GrabCheck>() != null && grabButton.action.IsPressed() && !menu1.activeSelf && !menu2.activeSelf)
        //{
        //    other.gameObject.transform.SetParent(attachPoint);
        //}
    }

    private void OnTriggerExit(Collider other)
    {
        // mayGrab = false;
        //if (other.gameObject.GetComponent<GrabCheck>() == null || !grabButton.action.IsPressed() || menu1.activeSelf || menu2.activeSelf)
        //{
        //    other.gameObject.transform.SetParent(null);
        //}

        if (other.gameObject.GetComponent<GrabCheck>() == null || !grabButton.action.IsPressed() || menu1.activeSelf || menu2.activeSelf)
        {
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;

            if (other.gameObject.GetComponent<GrabCheck>() != null)
            {
                other.gameObject.GetComponent<GrabCheck>().isBeingGrabbed = false;
            }

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name != "LeftHandTriggerCollider" && other.gameObject.name != "RightHandTriggerCollider")
        {
            //Debug.Log(other.gameObject.name);
            if (other.gameObject.GetComponent<GrabCheck>() != null && grabButton.action.IsPressed() && !menu1.activeSelf && !menu2.activeSelf)
            {
                //Debug.Log("ENTRO AQUI");
                //other.gameObject.transform.SetParent(attachPoint);
                other.gameObject.transform.position = attachPoint.position;
                other.gameObject.transform.rotation = attachPoint.rotation;
                other.gameObject.GetComponent<Rigidbody>().isKinematic = true;

                other.gameObject.GetComponent<GrabCheck>().isBeingGrabbed = true;

            }

            if (other.gameObject.GetComponent<GrabCheck>() == null || !grabButton.action.IsPressed() || menu1.activeSelf || menu2.activeSelf)
            {
                //Debug.Log("ENTRO AQUI 2");
                other.gameObject.GetComponent<Rigidbody>().isKinematic = false;

                if (other.gameObject.GetComponent<GrabCheck>() != null)
                {
                    other.gameObject.GetComponent<GrabCheck>().isBeingGrabbed = false;
                }
            }

            //if (other.gameObject.GetComponent<GrabCheck>() == null || !grabButton.action.IsPressed() || menu1.activeSelf || menu2.activeSelf)
            //{
            //    other.gameObject.transform.SetParent(null);
            //}
        }
        //if (other.gameObject.tag == "OrangeFlower") Debug.Log("AQUI");
        //if (other.gameObject.GetComponent<GrabCheck>() != null && grabButton.action.IsPressed() && !menu1.activeSelf && !menu2.activeSelf)
        //{
        //    Debug.Log("ENTRO A LA FLOR");
        //    other.gameObject.transform.position = attachPoint.position;
        //}
    }
}
