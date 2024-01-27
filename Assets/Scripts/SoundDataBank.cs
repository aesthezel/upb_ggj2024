using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "SoundDatabase", menuName = "AudioCloud")]
public class SoundDataBank : ScriptableObject
{
    [SerializeField] AudioClip MainTheme = default;
    [SerializeField] AudioClip HappyNun = default;
    [SerializeField] AudioClip PokerNun = default;
    [SerializeField] AudioClip UpsetNun = default;
    [SerializeField] AudioClip HappyDepressed = default;
    [SerializeField] AudioClip PokerDepressed = default;
    [SerializeField] AudioClip UpsetDepressed = default;
    [SerializeField] AudioClip HappyNarco = default;
    [SerializeField] AudioClip PokerNarco = default;
    [SerializeField] AudioClip UpsetNarco = default;
    [SerializeField] AudioClip LaughingAudience = default;
    [SerializeField] AudioClip BackGroundGameplayMusic = default;
    [SerializeField] AudioClip CannonShot = default;
    [SerializeField] AudioClip FallingAnvil = default;
    [SerializeField] AudioClip AnvilHit = default;
    [SerializeField] AudioClip HittingTheFloor = default;
    [SerializeField] AudioClip DabHorns = default;
    [SerializeField] AudioClip FlyingTomato = default;
    [SerializeField] AudioClip TomatoSplash = default;
    [SerializeField] AudioClip SurpriseChicken = default;
    [SerializeField] AudioClip FrenchMime = default;
    [SerializeField] AudioClip ActionSelected1 = default;
    [SerializeField] AudioClip ActionSelected2 = default;
    [SerializeField] AudioClip ActionSelected3 = default;
    [SerializeField] AudioClip MouseOver = default;
    [SerializeField] AudioClip ButtonSFX = default;
    [SerializeField] AudioClip GameOverJingle = default;
    [SerializeField] AudioClip WinningJingle = default;
    [SerializeField] AudioClip ElevatorMusic = default;
    [SerializeField] AudioClip DefaultSound = default;

    public AudioClip GetFromDataBank(AudioManager.AudioSamples samples) => samples switch
    {
        AudioManager.AudioSamples.mainTheme=> MainTheme,
        AudioManager.AudioSamples.happyNun=> HappyNun,
        AudioManager.AudioSamples.pokerNun=> PokerNun,
        AudioManager.AudioSamples.upsetNun=> UpsetNun,
        AudioManager.AudioSamples.happyDepressed=> HappyDepressed,
        AudioManager.AudioSamples.pokerDepressed=> PokerDepressed,
        AudioManager.AudioSamples.upsetDepressed=> UpsetDepressed,
        AudioManager.AudioSamples.happyNarco=> HappyNarco,
        AudioManager.AudioSamples.pokerNarco=> PokerNarco,
        AudioManager.AudioSamples.upsetNarco=> UpsetNarco,
        AudioManager.AudioSamples.laughingAudience=> LaughingAudience,
        AudioManager.AudioSamples.BGGameplayMusic => BackGroundGameplayMusic,
        AudioManager.AudioSamples.cannonShot=> CannonShot,
        AudioManager.AudioSamples.fallingAnvil => FallingAnvil,
        AudioManager.AudioSamples.anvilHit => AnvilHit,
        AudioManager.AudioSamples.hittingTheFlor => HittingTheFloor,
        AudioManager.AudioSamples.dabHorns=> DabHorns,
        AudioManager.AudioSamples.flyingTomato => FlyingTomato,
        AudioManager.AudioSamples.tomatoSplash=> TomatoSplash,
        AudioManager.AudioSamples.surpriseChicken => SurpriseChicken,
        AudioManager.AudioSamples.frenchMime=> FrenchMime,
        AudioManager.AudioSamples.actionSelect1 => ActionSelected1,
        AudioManager.AudioSamples.actionSelect2 => ActionSelected2,
        AudioManager.AudioSamples.actionSelect3 => ActionSelected3,
        AudioManager.AudioSamples.mouseOver => MouseOver,
        AudioManager.AudioSamples.buttonSFX=> ButtonSFX,
        AudioManager.AudioSamples.gameOverJingle=> GameOverJingle,
        AudioManager.AudioSamples.winningJingle=> WinningJingle,
        AudioManager.AudioSamples.elevatorMusic => ElevatorMusic,
        _ => DefaultSound
    };

}
