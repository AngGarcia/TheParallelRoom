using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    [SerializeField]
    private KeyLocker locker;

    private Rigidbody rb;
    private BoxCollider bc;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        bc = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TaquillaAbierta");
        if (other.gameObject.CompareTag("Key"))
        {
            locker.setOpen();
            rb.isKinematic = false;
            bc.isTrigger = false;
            this.gameObject.GetComponent<AudioSource>().Play(0);
        }
    }
}
