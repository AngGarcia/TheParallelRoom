using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{

    [SerializeField] private Material lightUpMat;
    [SerializeField] private GameObject pointLightObj;
    [SerializeField]
    private GameObject codigo;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Match") 
        {
            this.gameObject.GetComponent<MeshRenderer>().material = lightUpMat;
            pointLightObj.SetActive(true);
            codigo.SetActive(true);
        }
   
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BlowtorchFlame")
        {
            this.gameObject.GetComponent<MeshRenderer>().material = lightUpMat;
            pointLightObj.SetActive(true);
            codigo.SetActive(true);
        }
    }
}
