using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTester : MonoBehaviour
{

     Animator AnimatorTest;

    void Awake()
    {
        AnimatorTest = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            print("Backflip");
            AnimatorTest.SetBool("Backflip", true);

            StartCoroutine(WaitSeconds(3, AnimatorTest));

            
        }
        
    }

    public static IEnumerator WaitSeconds(int seconds, Animator animator)
    {
        yield return new WaitForSeconds(seconds);

        bool Extra = animator.GetBool("Backflip");
        animator.SetBool("Backflip", false);
        print(animator);
        Debug.Log(Extra);


    }
}
