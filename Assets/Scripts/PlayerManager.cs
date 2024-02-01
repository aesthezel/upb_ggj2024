using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Animator animator;
    [SerializeField] ThrowObject launch;
    public GameObject spawnObject;
    [SerializeField] Canvas UIToHide;

    public void performAnimation(ActionCard actionCard)
    {
        animator.SetBool(actionCard.cardAnimation,true);
      
        UIToHide.enabled = false;
        StartCoroutine(WaitAnim(4, animator, actionCard.cardAnimation,UIToHide));
        switch (actionCard.cardAnimation)
        {
            case "Iron":
                AudioManager.instance.PlayOneshotSFX(actionCard.cardAudio);
                AudioManager.instance.SFXSource.clip = AudioManager.instance.AudioDataBank.GetFromDataBank(AudioManager.AudioSamples.anvilHit);
                AudioManager.instance.SFXSource.PlayDelayed(2);
                break;
            default:
                AudioManager.instance.PlayOneshotSFX(actionCard.cardAudio);
                break;
        }
        Debug.Log("animation");
    }

    public void performSpawn(ActionCard actionCard)
    {
        animator.SetBool(actionCard.cardAnimation, true);
        UIToHide.enabled = false;
        switch (actionCard.cardAnimation)
        {
            case "Iron":
                AudioManager.instance.PlayOneshotSFX(actionCard.cardAudio);
                AudioManager.instance.SFXSource.clip = AudioManager.instance.AudioDataBank.GetFromDataBank(AudioManager.AudioSamples.anvilHit);
                AudioManager.instance.SFXSource.PlayDelayed(2);
                break;
            case "Toss":
                AudioManager.instance.PlayOneshotSFX(actionCard.cardAudio);
                launch.ThrowTomato();
                break;
            case "Chicken":
                AudioManager.instance.PlayOneshotSFX(actionCard.cardAudio);
                launch.ThrowChicken();
                break;
            default:
                AudioManager.instance.PlayOneshotSFX(actionCard.cardAudio);
                break;
        }
        StartCoroutine(WaitAnim(4, animator, actionCard.cardAnimation,UIToHide));
      
        Debug.Log("Spawn");
    }

    public static IEnumerator WaitAnim(int seconds, Animator animator, string nameOfAction, Canvas canvas)
    {
        yield return new WaitForSeconds(seconds);
        animator.SetBool(nameOfAction, false);
        canvas.enabled = true;
    }
}
