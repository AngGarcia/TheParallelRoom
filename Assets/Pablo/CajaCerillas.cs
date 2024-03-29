using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CajaCerillas : MonoBehaviour
{
    public bool isGrabbed;

    public bool isGrabbedLeftHand;
    public bool isGrabbedRightHand;

    public GameObject cerillaPrefab;
    public Transform spawnCerillaLeftHand;
    public Transform spawnCerillaRightHand;

    public InputActionProperty primaryGrabButtonLeftHand;
    public InputActionProperty primaryGrabButtonRightHand;

    public InputActionProperty grabButtonLeftHand;
    public InputActionProperty grabButtonRightHand;

    public Collider leftHand;
    public Collider rightHand;

    // Start is called before the first frame update
    void Start()
    {
        isGrabbed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void isGrabbedTrue()
    {
        isGrabbed = true;
        isGrabbedLeftHandCheck();
        isGrabbedRightHandCheck();

    }

    public void isGrabbedLeftHandCheck()
    {
        if(primaryGrabButtonLeftHand.action.IsPressed() && !primaryGrabButtonRightHand.action.IsPressed())
        {
            isGrabbedLeftHand = true;
            leftHand.enabled = false;
        }
        else
        {
            isGrabbedLeftHand = false;
            leftHand.enabled = true;
        }
    }

    public void isGrabbedRightHandCheck()
    {
        if (!primaryGrabButtonLeftHand.action.IsPressed() && primaryGrabButtonRightHand.action.IsPressed())
        {
            isGrabbedRightHand = true;
            rightHand.enabled = false;
        }
        else
        {
            isGrabbedRightHand = false;
            rightHand.enabled = true;
        }
    }

    public void isGrabbedFalse() 
    {
        isGrabbed = false;
        isGrabbedLeftHand = false;
        isGrabbedRightHand = false;
        leftHand.enabled = true;
        rightHand.enabled = true;
    }

    private void OnTriggerStay(Collider other)
    {
        //if (other.gameObject.tag== "LeftHandTriggerCollider" && grabButtonLeftHand.action.IsPressed())
        //{
        //    Debug.Log("HOLAAA1");
        //}

        //if (other.gameObject.tag == "RightHandTriggerCollider")
        //{
        //    Debug.Log("HOLAAA2");
        //}

        if ( isGrabbedRightHand && other.gameObject.tag == "LeftHandTriggerCollider" && grabButtonLeftHand.action.WasPressedThisFrame())
        {
            GameObject newCerilla = Instantiate(cerillaPrefab, new Vector3(spawnCerillaLeftHand.position.x, spawnCerillaLeftHand.position.y+0.1f, spawnCerillaLeftHand.position.z) , Quaternion.identity);
            //Debug.Log("ENTRO_MANO_DCHA");
            //other.gameObject.transform.position = attachPoint.position;
            newCerilla.GetComponent<Match>().deactivateGravity();
            StartCoroutine(gravityTimer(newCerilla));
        }

        if (isGrabbedLeftHand && other.gameObject.tag == "RightHandTriggerCollider" && grabButtonRightHand.action.WasPressedThisFrame())
        {
            GameObject newCerilla = Instantiate(cerillaPrefab, new Vector3(spawnCerillaRightHand.position.x, spawnCerillaRightHand.position.y+0.1f, spawnCerillaRightHand.position.z) , Quaternion.identity);
            //other.gameObject.transform.position = attachPoint.position;
            //Debug.Log("ENTRO_MANO_IZQDA");
            newCerilla.GetComponent<Match>().deactivateGravity();
            StartCoroutine(gravityTimer(newCerilla));
        }
    }

    IEnumerator gravityTimer(GameObject cerilla)
    {
        yield return new WaitForSeconds(5.0f);
        cerilla.GetComponent<Rigidbody>().isKinematic = false;
    }
}
