using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitLevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {

        }
    }
}
