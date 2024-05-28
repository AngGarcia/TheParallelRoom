using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitSign : MonoBehaviour
{
    public void quitGame()
    {
        SceneChanger.Instance.exitGame();
    }

    public void test()
    {
        Debug.Log("HOLAAAAAAAAAAAAAAAAAAAAAAAA");
    }
}
