using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HingeCollision : MonoBehaviour
{
    [SerializeField]
    private DestructableHinge DH;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BlowtorchFlame")
        {
            this.gameObject.SetActive(false);
            DH.restaNOH();
        }
    }
}
