using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class CajaCerillas : MonoBehaviour
{
    [SerializeField] private bool isGrabbedLeftHand;
    [SerializeField] private bool isGrabbedRightHand;

    [SerializeField] private GameObject cerillaPrefab;
    [SerializeField] private Transform spawnCerillaLeftHand;
    [SerializeField] private Transform spawnCerillaRightHand;

    [SerializeField] private InputActionProperty primaryGrabButtonLeftHand;
    [SerializeField] private InputActionProperty primaryGrabButtonRightHand;

    [SerializeField] private InputActionProperty grabButtonLeftHand;
    [SerializeField] private InputActionProperty grabButtonRightHand;

    [SerializeField] private Collider leftHand;
    [SerializeField] private Collider rightHand;

    [SerializeField] private bool resetCerilla = false;
    [SerializeField] private float timeToReset = 2.5f;


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

    private void OnTriggerStay(Collider other)
    {
        if ( isGrabbedRightHand && other.gameObject.tag == "LeftHandTriggerCollider" && grabButtonLeftHand.action.IsPressed() && !resetCerilla)
        {
            GameObject newCerilla = Instantiate(cerillaPrefab, new Vector3(spawnCerillaLeftHand.position.x, spawnCerillaLeftHand.position.y+0.1f, spawnCerillaLeftHand.position.z) , Quaternion.identity);
            resetCerilla = true;
            newCerilla.GetComponent<Match>().deactivateGravity();
            StartCoroutine(gravityTimer(newCerilla));    
        }

        if (isGrabbedLeftHand && other.gameObject.tag == "RightHandTriggerCollider" && grabButtonRightHand.action.IsPressed() && !resetCerilla)
        {
            GameObject newCerilla = Instantiate(cerillaPrefab, new Vector3(spawnCerillaRightHand.position.x, spawnCerillaRightHand.position.y+0.1f, spawnCerillaRightHand.position.z) , Quaternion.identity);
            resetCerilla = true;
            newCerilla.GetComponent<Match>().deactivateGravity();
            StartCoroutine(gravityTimer(newCerilla));
        }
    }

    IEnumerator gravityTimer(GameObject cerilla)
    {
        yield return new WaitForSeconds(5.0f);
        cerilla.GetComponent<Rigidbody>().isKinematic = false;
        StartCoroutine(resetCerillaFunc());
    }

    IEnumerator resetCerillaFunc()
    {
        yield return new WaitForSeconds(timeToReset);
        resetCerilla = false;
    }
}
