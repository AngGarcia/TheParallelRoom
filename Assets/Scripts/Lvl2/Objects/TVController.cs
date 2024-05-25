using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVController : MonoBehaviour
{
    [SerializeField]
    private MeshRenderer tvScreen;
    [SerializeField]
    private Television tv;

    [SerializeField]
    private Material tvOff;
    [SerializeField]
    private Material tvOn;


    private bool switchTV;

    private void Start()
    {
        switchTV = false;
        tvScreen.material = tvOff;
    }

    public void turnOnTV()
    {
        MusicManager.Instance.PlaySound(AppSounds.TV_CONTROLLER_CLICK);

        if (switchTV){
            tvScreen.material = tvOff;
            tv.turnOFF();
            switchTV = false;
        }
        else
        {
            tvScreen.material = tvOn;
            tv.turnON();
            switchTV = true;
        }
    }
}
