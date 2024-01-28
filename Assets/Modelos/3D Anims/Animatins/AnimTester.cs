using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AnimTester : MonoBehaviour
{

    Animator AnimatorTest;
    public string nameOfAction = " ";

    void Awake()
    {
        AnimatorTest = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            //YA QUEDO
            nameOfAction = "Backflip";
            AnimatorTest.SetBool(nameOfAction, true);
            StartCoroutine(WaitSeconds(3, AnimatorTest, "Backflip"));
            AudioManager.instance.PlayOneshotSFX(AudioManager.AudioSamples.flyingTomato);
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            //AAA
            nameOfAction = "RagDoll";
            AnimatorTest.SetBool(nameOfAction, true);
            StartCoroutine(WaitSeconds(3, AnimatorTest, "RagDoll"));
            AudioManager.instance.PlayOneshotSFX(AudioManager.AudioSamples.hittingTheFlor);
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            //found
            nameOfAction = "Iron";
            AnimatorTest.SetBool(nameOfAction, true);
            StartCoroutine(WaitSeconds(3, AnimatorTest, "Iron"));
            AudioManager.instance.PlayOneshotSFX(AudioManager.AudioSamples.fallingAnvil);
            AudioManager.instance.SFXSource.PlayDelayed(2);
        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            //AAA
            nameOfAction = "Dab";
            AnimatorTest.SetBool(nameOfAction, true);
            StartCoroutine(WaitSeconds(3, AnimatorTest, "Dab"));
            AudioManager.instance.PlayOneshotSFX(AudioManager.AudioSamples.dabHorns);
        }
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            //Dance DONE
            nameOfAction = "Dance";
            AnimatorTest.SetBool(nameOfAction, true);
            StartCoroutine(WaitSeconds(4, AnimatorTest, "Dance"));
        }

        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            //Dance DONE
            nameOfAction = "Toss";
            AnimatorTest.SetBool(nameOfAction, true);
            StartCoroutine(WaitSeconds(4, AnimatorTest, "Toss"));
        }

        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            //Dance DONE
            nameOfAction = "Canon Hit";
            AnimatorTest.SetBool(nameOfAction, true);
            StartCoroutine(WaitSeconds(4, AnimatorTest, "Canon Hit"));
        }


    }

    public static IEnumerator WaitSeconds(int seconds, Animator animator, string nameOfAction)
    {
        yield return new WaitForSeconds(seconds);
        animator.SetBool(nameOfAction, false);
    }
}
