using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVController : MonoBehaviour
{
    [SerializeField]
    private GameObject tv;

    [SerializeField]
    private Material tvOff;
    [SerializeField]
    private Material tvOn;


    private bool switchTV;

    private void Start()
    {
        switchTV = false;
        tv.GetComponent<MeshRenderer>().material = tvOff;
    }

    public void turnOnTV()
    {
        if(switchTV){
            tv.GetComponent<MeshRenderer>().material = tvOff;
            switchTV = false;
        }
        else
        {
            tv.GetComponent<MeshRenderer>().material = tvOn;
            switchTV = true;
        }
    }
}
