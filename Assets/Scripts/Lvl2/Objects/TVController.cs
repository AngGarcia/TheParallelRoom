using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVController : MonoBehaviour
{
    [SerializeField]
    private GameObject tvScreen;
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
        tvScreen.GetComponent<MeshRenderer>().material = tvOff;
    }

    public void turnOnTV()
    {
        MusicManager.Instance.PlaySound(AppSounds.TV_CONTROLLER_CLICK);

        if (switchTV){
            tvScreen.GetComponent<MeshRenderer>().material = tvOff;
            tv.GetComponent<Television>().turnOFF();
            switchTV = false;
        }
        else
        {
            tvScreen.GetComponent<MeshRenderer>().material = tvOn;
            tv.GetComponent<Television>().turnON();
            switchTV = true;
        }
    }
}
