using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] SoundDataBank soundDB;
    public SoundDataBank AudioDataBank => soundDB;
    public AudioSource SFXSource, MusicSource;
    public static AudioManager instance = null;
    public enum AudioSamples
    {
        mainTheme = 0,happyNun = 1,pokerNun = 2, upsetNun = 3, happyDepressed = 4, pokerDepressed = 5, upsetDepressed = 6,
        happyNarco= 7, pokerNarco= 8, upsetNarco = 9, laughingAudience = 10, BGGameplayMusic = 11, cannonShot = 12,
        fallingAnvil = 13, anvilHit = 14, hittingTheFlor = 15, dabHorns = 16,flyingTomato = 17,tomatoSplash = 18,
        surpriseChicken = 19,frenchMime = 20, actionSelect1 = 21, actionSelect2 = 22, actionSelect3 = 23, mouseOver = 24,
        buttonSFX = 25, gameOverJingle = 26, winningJingle = 27
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
}
