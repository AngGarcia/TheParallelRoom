using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPoke : MonoBehaviour
{

    //[SerializeField]
    //private GameObject pokeInteractorLeft;

    //[SerializeField]
    //private GameObject pokeInteractorRight;

    //[SerializeField]
    //private BoxCollider leftControllerCollider;

    //[SerializeField]
    //private BoxCollider rightControllerCollider;

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "LeftHandTriggerCollider")
        //{
        //    //Debug.Log("Activo Poke Izquierdo en trigger");
        //    pokeInteractorLeft.SetActive(true);
        //    //Debug.Log(pokeInteractorLeft.gameObject.activeSelf);
        //    leftControllerCollider.enabled = false;
        //}
        //if(other.gameObject.tag == "RightHandTriggerCollider")
        //{
        //    pokeInteractorRight.SetActive(true);
        //    rightControllerCollider.enabled = false;
        //}

        if (other.gameObject.tag == "LeftHandTriggerCollider" || other.gameObject.tag == "RightHandTriggerCollider")
        {
            SceneChanger.Instance.exitGame();
        }

    }

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.tag == "LeftHandTriggerCollider")
    //    {
    //        pokeInteractorLeft.SetActive(false);
    //        leftControllerCollider.enabled = true;
    //    }
    //    if (other.gameObject.tag == "RightHandTriggerCollider")
    //    {
    //        pokeInteractorRight.SetActive(false);
    //        rightControllerCollider.enabled = true;
    //    }
    //}
}
