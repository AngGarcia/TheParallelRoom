using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{

    public Material lightUpMat;
    public GameObject pointLightObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Match") 
        {
            this.gameObject.GetComponent<MeshRenderer>().material = lightUpMat;
            pointLightObj.SetActive(true);
        }
    }
}
