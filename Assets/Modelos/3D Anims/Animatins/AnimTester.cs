using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            //AAA
            nameOfAction = "RagDoll";
            AnimatorTest.SetBool(nameOfAction, true);
            StartCoroutine(WaitSeconds(3, AnimatorTest, "RagDoll"));
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            //found
            nameOfAction = "Iron";
            AnimatorTest.SetBool(nameOfAction, true);
            StartCoroutine(WaitSeconds(3, AnimatorTest, "Iron"));
        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            //AAA
            nameOfAction = "Dab";
            AnimatorTest.SetBool(nameOfAction, true);
            StartCoroutine(WaitSeconds(3, AnimatorTest, "Dab"));
        }
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            //Dance DONE
            nameOfAction = "Dance";
            AnimatorTest.SetBool(nameOfAction, true);
            StartCoroutine(WaitSeconds(4, AnimatorTest, "Dance"));
        }


    }

    public static IEnumerator WaitSeconds(int seconds, Animator animator, string nameOfAction)
    {
        yield return new WaitForSeconds(seconds);
        animator.SetBool(nameOfAction, false);
    }
}
