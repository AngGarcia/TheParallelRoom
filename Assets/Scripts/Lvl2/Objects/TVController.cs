using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVController : MonoBehaviour
{
    [SerializeField]
    private GameObject tvScreen;

    private bool switchTV;

    private void Start()
    {
        switchTV = false;
    }

    public void turnOnTV()
    {
        if(switchTV){
            tvScreen.SetActive(false);
            switchTV = false;
        }
        else
        {
            tvScreen.SetActive(true);
            switchTV = true;
        }
    }
}
