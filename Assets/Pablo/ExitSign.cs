using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitSign : MonoBehaviour
{
    public void quitGame()
    {
        GameManager.SceneChangerInstance.exitGame();
    }
}
