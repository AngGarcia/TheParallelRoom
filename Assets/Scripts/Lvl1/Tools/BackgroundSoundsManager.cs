using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSoundsManager : MonoBehaviour
{
    [SerializeField]
    private AudioClip mineroSong;
    [SerializeField]
    private AudioClip ambientMusic;


    private float delayTime = 30f;
    private float actualTime = 0f;
    private float numAudio = 0.0f;

    void Start()
    {
        //StartCoroutine(PlayAudioWithDelay());
        MusicManager.Instance.PlayBackgroundMusic(AppSounds.LVL1_BACKGROUND_MUSIC);
    }

    private void Update()
    {
        actualTime += Time.deltaTime;

        if (actualTime >= delayTime)
        {
            numAudio = Mathf.RoundToInt(Random.Range(0f, 1f));

            if (numAudio == 0)
            {
                MusicManager.Instance.PlayBackgroundSound(AppSounds.ROCKS_FALLING);
            }
            else
            {
                MusicManager.Instance.PlayBackgroundSound(AppSounds.EXPLOSION);
            }

            actualTime = 0;
        }
    }

}
