using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPoke : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LeftHandTriggerCollider" || other.gameObject.tag == "RightHandTriggerCollider")
        {
            SceneChanger.Instance.exitGame();
        }
    }
}
