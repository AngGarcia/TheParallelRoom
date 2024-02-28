using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poster : MonoBehaviour
{
    // Start is called before the first frame update

    SceneChanger sceneChanger;

    private void Start()
    {
        
        sceneChanger = new SceneChanger();
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.gameObject.tag == "Player")
    //    {
    //        Debug.Log("Entro");
    //        sceneChanger.lvl1();
    //    }
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.tag == "Player")
    //    {
    //        Debug.Log("Entro");
    //        sceneChanger.lvl1();
    //    }
    //}

    public void goToLvl1()
    {
        sceneChanger.lvl1();
    }
}
