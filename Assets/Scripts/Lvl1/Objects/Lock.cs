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

    public void abrirPuerta()
    {
        Debug.Log("TaquillaAbierta");
        locker.setOpen();
        rb.isKinematic = false;
        bc.isTrigger = false;
        //this.gameObject.GetComponent<AudioSource>().Play(0);
        MusicManager.Instance.PlaySound(AppSounds.INSERT_KEY);
    }
}
