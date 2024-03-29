using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Match : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rigidbody;

    //private void Start()
    //{

    //    StartCoroutine(gravityTimer());
    //}
    public void activateGravity()
    {
        rigidbody.isKinematic = false;
    }

    public void deactivateGravity()
    {
        rigidbody.isKinematic = true;
    }

    IEnumerator gravityTimer()
    {
        yield return new WaitForSeconds(5.0f);
        this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
    }
}
