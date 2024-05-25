using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvanceLevel : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (GameManager.Instance.level == 1)
            {
                MusicManager.Instance.PlayBackgroundMusic(AppSounds.SOY_MINERO);
            }
            GameManager.Instance.level++;
            GameManager.Instance.saveToJson();
            GameManager.SceneChangerInstance.mainMenu();
        }

        if(other.gameObject.tag == "Key")
        {
            if (GameManager.Instance.level == 2)
            {
                MusicManager.Instance.PlayBackgroundMusic(AppSounds.SOY_MINERO);
            }
            GameManager.Instance.level=1;
            GameManager.Instance.saveToJson();
            GameManager.SceneChangerInstance.mainMenu();
        }
    }
}
