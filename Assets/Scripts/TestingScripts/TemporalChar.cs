using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemporalChar : MonoBehaviour
{
    Animator animator;
    bool alreadyAnim = false;
    // Start is called before the first frame update
    void Start()
    {
        animator= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && alreadyAnim == false)
        {
            animator.SetBool("Press Space", true);
            alreadyAnim = true;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && alreadyAnim == true)
        {
            animator.SetBool("Press Space", false);
            alreadyAnim = false;
        }
    }
}
