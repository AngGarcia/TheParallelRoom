using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookForFaderScreen : MonoBehaviour
{
    [SerializeField] private FadeScreen fade;

    void Start()
    {
        //Debug.Log("BuscoFade" + GameManager.Instance.level);
        SceneChanger.Instance.fadeScreen = fade;
    }

}
