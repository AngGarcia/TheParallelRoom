using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : PersistentSingleton<SceneChanger>
{
    // Start is called before the first frame update
    //public AudioSource audioSource;
    //public AudioClip button;
    public FadeScreen fadeScreen;
    private void Start()
    {
        Time.timeScale = 1;

        SceneManager.sceneLoaded += OnSceneLoaded;
    }


    public void lvl1()
    {
        StartCoroutine(delayLvl1());
    }

    public void lvl2()
    {
        StartCoroutine(delayLvl2());
    }

    public void mainMenu()
    {
        StartCoroutine (delayMainMenuScreen());
    }

    public void exitGame()
    {
        Application.Quit();
    }

    IEnumerator delayLvl1()
    {
        fadeScreen.FadeOut();

        yield return new WaitForSecondsRealtime(fadeScreen.fadeDuration);
       
        GameManager.Instance.level = 1;
        GameManager.Instance.saveToJson();
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene("Lvl1_Mines");
    }

    IEnumerator delayLvl2()
    {
        fadeScreen.FadeOut();

        yield return new WaitForSecondsRealtime(fadeScreen.fadeDuration);
       
        GameManager.Instance.level = 2;
        GameManager.Instance.saveToJson();
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene("Lvl2_Habitacion");
    }

    IEnumerator delayMainMenuScreen()
    {
        fadeScreen.FadeOut();
        
        yield return new WaitForSeconds(fadeScreen.fadeDuration);

        GameManager.Instance.saveToJson();
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene("MainMenu");

    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (GameObject.FindWithTag("faderScreen") != null)
            fadeScreen = GameObject.FindWithTag("faderScreen").GetComponent<FadeScreen>();
    }

    IEnumerator delayExit()
    {
        fadeScreen.FadeOut();

        yield return new WaitForSeconds(fadeScreen.fadeDuration);

        Application.Quit();
    }
}
