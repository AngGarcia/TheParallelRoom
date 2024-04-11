using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvanceLevel : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameManager.Instance.level++;
            GameManager.Instance.saveToJson();
            GameManager.SceneChangerInstance.mainMenu();
        }
    }
}
