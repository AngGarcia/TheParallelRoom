using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poster : MonoBehaviour
{
    // Start is called before the first frame update


    private void Start()
    {
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
        GameManager.SceneChangerInstance.lvl1();
    }
}
