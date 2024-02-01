using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [SerializeField] SoundDataBank soundDB;
    [SerializeField] float FadeTime, TargetVolume;
    public SoundDataBank AudioDataBank => soundDB;
    public AudioMixer Mixer;
    public AudioSource SFXSource, musicSource;
    public static AudioManager instance = null;
    public enum AudioSamples
    {
        mainTheme = 0,happyNun = 1,pokerNun = 2, upsetNun = 3, happyDepressed = 4, pokerDepressed = 5, upsetDepressed = 6,
        happyNarco= 7, pokerNarco= 8, upsetNarco = 9, laughingAudience = 10, BGGameplayMusic = 11, cannonShot = 12,
        fallingAnvil = 13, anvilHit = 14, hittingTheFlor = 15, dabHorns = 16,flyingTomato = 17,tomatoSplash = 18,
        surpriseChicken = 19,frenchMime = 20, actionSelect1 = 21, actionSelect2 = 22, actionSelect3 = 23, mouseOver = 24,
        buttonSFX = 25, gameOverJingle = 26, winningJingle = 27,elevatorMusic = 28
    }
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
           instance= this;
        }
        DontDestroyOnLoad(gameObject);
    }
    public static IEnumerator StartFadeMixer(AudioMixer mixer,string exposedGroup,float fadeTime,float targetVolume)
    {
        float currentTime = 0;
        float currentVol;
        mixer.GetFloat(exposedGroup, out currentVol);
        currentVol = Mathf.Pow(10, currentVol / 20);
        float targetValue = Mathf.Clamp(targetVolume, 0.0001f, 1);
        
        while (currentTime < fadeTime)
        {
            currentTime+= Time.deltaTime;
            float newVol = Mathf.Lerp(currentVol, targetValue, currentTime / fadeTime);
            mixer.SetFloat(exposedGroup, Mathf.Log10(newVol) * 20);
            yield return null;
        }
        yield break;
    }
    public void ChangeVolume(float targetVolume, string exposedMixedGroup) 
    {
        Mixer.SetFloat(exposedMixedGroup, Mathf.Log10(targetVolume)*20);
    }
    public void PlayOneshotSFX(AudioSamples sample)
    {
        SFXSource.PlayOneShot(soundDB.GetFromDataBank(sample));
    }
    private void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
    {
        switch (scene.buildIndex)
        {
            case 0:
                StartCoroutine(StartFadeMixer(Mixer,"ST", FadeTime, TargetVolume));
                PlayMusic(AudioSamples.mainTheme);
                break;
            case 1:
                PlayMusic(AudioSamples.BGGameplayMusic);
                break;
            default:
                break;
        }
    }
    public void PlayMusic(AudioSamples sample)
    {
        musicSource.clip = soundDB.GetFromDataBank(sample);
        musicSource.Play();
    }
}
