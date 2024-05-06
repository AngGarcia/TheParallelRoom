using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poster : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject poster;
    public Material poster1;
    public Material poster2;
    public Material poster3;

    private bool canChangeScene = true;


    private void Start()
    {
        if (GameManager.LastSceneDataInstance.lastLevel <=1)
        {
            poster.GetComponent<MeshRenderer>().material = poster1;
        }

        else if(GameManager.LastSceneDataInstance.lastLevel <= 2)
        {
            poster.GetComponent<MeshRenderer>().material = poster2;
        }

        else
        {
            poster.GetComponent<MeshRenderer>().material = poster3;
        }

        canChangeScene = true;
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

    public void goToLvl2()
    {
        GameManager.SceneChangerInstance.lvl1();
    }

    public void goToLvl3()
    {
        GameManager.SceneChangerInstance.lvl1();
    }

    public void goToLvl()
    { 
        if (canChangeScene) 
        {
            if (GameManager.LastSceneDataInstance.lastLevel == 2)
            {
                canChangeScene = false;
                goToLvl2();
                
            }

            else if (GameManager.LastSceneDataInstance.lastLevel == 3)
            {
                canChangeScene = false;
                goToLvl3();
            }

            else
            {
                canChangeScene = false;
                goToLvl1();
            }
        }
        
    }
}
