using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVController : MonoBehaviour
{
    [SerializeField]
    private GameObject tvScreen;
    [SerializeField]
    private GameObject tvLight;

    [SerializeField]
    private Material tvOff;
    [SerializeField]
    private Material tvOn;


    private bool switchTV;

    private void Start()
    {
        switchTV = false;
        tvLight.SetActive(false);
        tvScreen.GetComponent<MeshRenderer>().material = tvOff;
    }

    public void turnOnTV()
    {
        if(switchTV){
            tvScreen.GetComponent<MeshRenderer>().material = tvOff;
            tvLight.SetActive(false);
            switchTV = false;
        }
        else
        {
            tvScreen.GetComponent<MeshRenderer>().material = tvOn;
            tvLight.SetActive(true);
            switchTV = true;
        }
    }
}
