using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{

    public Material lightUpMat;
    public GameObject pointLightObj;
    [SerializeField]
    private GameObject codigo;
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
