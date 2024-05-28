using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : PersistentSingleton<MusicManager>
{
    [Range (0,1)]public float modifier=0.5f;
    public float volumeMusic;

    public float MusicVolume
    {
        get
        {
            return volumeMusic;
        }
        set
        {
            value = Mathf.Clamp01(value);
            //PlayerPrefs.SetFloat(AppPlayerPrefKeys.MUSIC_VOLUME, value);
            volumeMusic = value;
        }
    }

    public float MusicVolumeSave
    {
        get
        {
            return volumeMusic;
        }
        set
        {
            value = Mathf.Clamp01(value);
            m_backgroundMusic.volume = volumeMusic;
            //PlayerPrefs.SetFloat(AppPlayerPrefKeys.MUSIC_VOLUME, value);
            volumeMusic = value;
        }
    }

    public float volumeSfx;

    public float SfxVolume
    {
        get
        {
            return volumeSfx;
        }
        set
        {
            value = Mathf.Clamp01(value);
            //PlayerPrefs.SetFloat(AppPlayerPrefKeys.SFX_VOLUME, value);
            volumeSfx = value;
        }
    }

    public float SfxVolumeSave
    {
        get
        {
            return volumeSfx;
        }
        set
        {
            value = Mathf.Clamp01(value);
            m_sfxMusic.volume = volumeSfx;
            //PlayerPrefs.SetFloat(AppPlayerPrefKeys.SFX_VOLUME, value);
            volumeSfx = value;
        }
    }

    public float volumeBackgroundSfx;
    public float BackgroundSfxVolume
    {
        get
        {
            return volumeBackgroundSfx;
        }
        set
        {
            value = Mathf.Clamp01(value);
            //PlayerPrefs.SetFloat(AppPlayerPrefKeys.SFX_VOLUME, value);
            volumeBackgroundSfx = value * modifier;
        }
    }
    public float BackgroundSfxVolumeSave
    {
        get
        {
            return volumeBackgroundSfx;
        }
        set
        {
            value = Mathf.Clamp01(value);
            volumeBackgroundSfx = value * modifier;
            m_backgroundSfxMusic.volume = volumeBackgroundSfx;
            //PlayerPrefs.SetFloat(AppPlayerPrefKeys.SFX_VOLUME, value);
            
        }
    }

    public override void Awake()
    {
        base.Awake();

        m_backgroundMusic = CreateAudioSource("Music", true);
        m_sfxMusic = CreateAudioSource("Sfx", false);
        m_backgroundSfxMusic = CreateAudioSource("Background_Sfx", false);

        m_soundMusicDictionary = new Dictionary<string, AudioClip>();
        m_soundFXDictionary = new Dictionary<string, AudioClip>();
        m_soundFXBackgoundDictionary = new Dictionary<string, AudioClip>();

        AudioClip[] audioSfxVector = Resources.LoadAll<AudioClip>(AppPaths.PATH_RESOURCE_SFX);

        for (int i = 0; i < audioSfxVector.Length; i++)
        {
            m_soundFXDictionary.Add(audioSfxVector[i].name, audioSfxVector[i]);
        }

        audioSfxVector = Resources.LoadAll<AudioClip>(AppPaths.PATH_RESOURCE_MUSIC);

        for (int i = 0; i < audioSfxVector.Length; i++)
        {
            m_soundMusicDictionary.Add(audioSfxVector[i].name, audioSfxVector[i]);
        }

        audioSfxVector = Resources.LoadAll<AudioClip>(AppPaths.PATH_RESOURCE_SFX_BACKGROUND);

        for (int i = 0; i < audioSfxVector.Length; i++)
        {
            m_soundFXBackgoundDictionary.Add(audioSfxVector[i].name, audioSfxVector[i]);
        }

    }

    private void Start()
    {
        MusicVolume = GameManager.CommonVariablesInstance.volumeMusic;
        SfxVolume = GameManager.CommonVariablesInstance.volumeSfx;
        BackgroundSfxVolume = SfxVolume;
    }

    public void PlayBackgroundMusic(string audioName)
    {
        if (m_soundMusicDictionary.ContainsKey(audioName))
        {
            Debug.Log("Audio name " + audioName);
            m_backgroundMusic.clip = m_soundMusicDictionary[audioName];
            m_backgroundMusic.volume = MusicVolume;
            m_backgroundMusic.Play();
        }
    }

    public void PlaySound(string audioName)
    {
        if (m_sfxMusic.clip = m_soundFXDictionary[audioName])
        {
            m_sfxMusic.clip = m_soundFXDictionary[audioName];
            m_sfxMusic.volume = SfxVolume;
            m_sfxMusic.Play();
        }
    }

    public void PlayBackgroundSound(string audioName)
    {
        if (m_backgroundSfxMusic.clip = m_soundFXBackgoundDictionary[audioName])
        {
            m_backgroundSfxMusic.clip = m_soundFXBackgoundDictionary[audioName];
            m_backgroundSfxMusic.volume = BackgroundSfxVolume;
            m_backgroundSfxMusic.Play();
        }
    }

    public void StopBackgroundMusic()
    {
        if (m_backgroundMusic != null)
            m_backgroundMusic.Stop();
    }

    public void PauseBackgroundMusic()
    {
        if (m_backgroundMusic != null)
            m_backgroundMusic.Pause();
    }

    public AudioSource CreateAudioSource(string name, bool isLoop)
    {
        GameObject tempAudioHost = new GameObject(name);
        AudioSource audioSource = tempAudioHost.AddComponent<AudioSource>() as AudioSource;
        audioSource.playOnAwake = false;
        audioSource.loop = isLoop;
        audioSource.spatialBlend = 0.0f;
        tempAudioHost.transform.SetParent(this.transform);

        return audioSource;
    }

    private Dictionary<string, AudioClip> m_soundMusicDictionary;
    private Dictionary<string, AudioClip> m_soundFXDictionary;
    private Dictionary<string, AudioClip> m_soundFXBackgoundDictionary;

    private AudioSource m_backgroundMusic;
    private AudioSource m_sfxMusic;
    private AudioSource m_backgroundSfxMusic;
}