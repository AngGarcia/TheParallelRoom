using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookForFaderScreen : MonoBehaviour
{
    [SerializeField] private FadeScreen fade;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("BuscoFade" + GameManager.Instance.level);
        SceneChanger.Instance.fadeScreen = fade;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
