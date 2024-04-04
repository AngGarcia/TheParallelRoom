using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVController : MonoBehaviour
{
    [SerializeField]
    private GameObject tvScreen;

    public void turnOnTV()
    {
        tvScreen.SetActive(true);
    }
}
