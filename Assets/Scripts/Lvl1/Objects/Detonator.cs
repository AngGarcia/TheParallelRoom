using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detonator : MonoBehaviour
{
    [SerializeField]
    private DinamiteSocket DinamiteSocket;
    private Transform startTransform;

    void Start()
    {
        startTransform = this.transform;    
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Mathf.Abs(startTransform.position.y) - Mathf.Abs(transform.position.y) < 0.35f);
        if(Mathf.Abs(startTransform.position.y) - Mathf.Abs(transform.position.y) < 0.35f && DinamiteSocket.getNumTnt() >= 3)
        {
            Debug.Log("EXPLOSION");
        }
    }
}
