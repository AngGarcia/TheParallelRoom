using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class GameManager : PersistentSingleton<GameManager>
{
    private string saveSlot1;
    private static CommonVariables commonVariablesInstance;
    private static LastSceneData lastSceneDataInstance;
    //private static SceneChanger sceneChangerInstance;

    public int level=0;

    public static CommonVariables CommonVariablesInstance
    {
        get
        {
            return commonVariablesInstance;
        }
    }
    public static LastSceneData LastSceneDataInstance
    {
        get
        {
            return lastSceneDataInstance;
        }
    }

    private void Awake()
    {
        saveSlot1 = Application.persistentDataPath + "/saveSlot1";

        if (!Directory.Exists(saveSlot1))
        {
            Directory.CreateDirectory(saveSlot1);
        }

        commonVariablesInstance = new CommonVariables();

        lastSceneDataInstance = new LastSceneData();


        loadFromJson();

        level = GameManager.LastSceneDataInstance.lastLevel;
    }

    void Start()
    {
        MusicManager.Instance.MusicVolume = GameManager.CommonVariablesInstance.volumeMusic;
        MusicManager.Instance.SfxVolume = GameManager.CommonVariablesInstance.volumeSfx;
        MusicManager.Instance.BackgroundSfxVolume = MusicManager.Instance.SfxVolume;
        MusicManager.Instance.MusicVolumeSave = GameManager.CommonVariablesInstance.volumeMusic;
        MusicManager.Instance.SfxVolumeSave = GameManager.CommonVariablesInstance.volumeSfx;
        MusicManager.Instance.BackgroundSfxVolumeSave = MusicManager.Instance.SfxVolume;
    }


    public void saveToJson()
    {

        string commonData = JsonUtility.ToJson(commonVariablesInstance);
        string commonFilePath = Application.persistentDataPath + "/saveSlot1/commonState.json";
        System.IO.File.WriteAllText(commonFilePath, commonData);


        lastSceneDataInstance.lastLevel = level;
        string lastSceneData = JsonUtility.ToJson(lastSceneDataInstance);
        string lastSceneDataFilePath = Application.persistentDataPath + "/saveSlot1/lastSceneData.json";
        System.IO.File.WriteAllText(lastSceneDataFilePath, lastSceneData);
    }

    public void loadFromJson()
    {
        //Common Variables
        string commonFilePath = Application.persistentDataPath + "/saveSlot1/commonState.json";
        if (File.Exists(commonFilePath))
        {
            string commonData = System.IO.File.ReadAllText(commonFilePath);

            commonVariablesInstance = JsonUtility.FromJson<CommonVariables>(commonData);
        }

        //lastSceneData
        string lastSceneDataFilePath = Application.persistentDataPath + "/saveSlot1/lastSceneData.json";
        if (File.Exists(lastSceneDataFilePath))
        {
            string lastSceneData = System.IO.File.ReadAllText(lastSceneDataFilePath);

            lastSceneDataInstance = JsonUtility.FromJson<LastSceneData>(lastSceneData);

        }
    }

    public bool saveFileExists()
    {
        string lvl1FilePath = Application.persistentDataPath + "/saveSlot1/lastSceneData.json";
        if (File.Exists(lvl1FilePath))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void resetProgress()
    {
        LastSceneDataInstance.lastLevel= 1;
        this.level = 1;
        saveToJson();
    }

}
