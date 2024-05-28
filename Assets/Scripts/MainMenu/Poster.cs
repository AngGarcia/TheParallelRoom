using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poster : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private MeshRenderer poster;
    [SerializeField] private Material poster1;
    [SerializeField] private Material poster2;
    [SerializeField] private Material poster3;

    [SerializeField] private bool canChangeScene = true;


    private void Start()
    {
        if (GameManager.LastSceneDataInstance.lastLevel <=1)
        {
            poster.material = poster1;
        }

        else if(GameManager.LastSceneDataInstance.lastLevel == 2)
        {
            poster.material = poster2;
        }

        else
        {
            poster.material = poster3;
        }

        canChangeScene = true;
    }

    public void updatePosterMaterial()
    {
        if (GameManager.LastSceneDataInstance.lastLevel <= 1)
        {
            poster.material = poster1;
        }

        else if (GameManager.LastSceneDataInstance.lastLevel == 2)
        {
            poster.material = poster2;
        }

        else
        {
            poster.material = poster3;
        }

        canChangeScene = true;
    }

    public void goToLvl1()
    {
        SceneChanger.Instance.lvl1();
    }

    public void goToLvl2()
    {
        SceneChanger.Instance.lvl2();
    }

    public void goToLvl3()
    {
        SceneChanger.Instance.lvl1();
    }

    public void goToLvl()
    { 
        if (canChangeScene) 
        {
            canChangeScene = false;
            StartCoroutine(resetButton());
        }    
    }

    IEnumerator resetButton()
    {
        yield return new WaitForSeconds(2.0f);

        if (GameManager.Instance.level <= 1)
        {
            goToLvl1();
        }
        else if (GameManager.Instance.level == 2)
        {
            goToLvl2();
        }
        
        canChangeScene = true;
    }
}
