using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Animator animator;
    public GameObject spawnObject;

    public void Start()
    {

    }

    public void performAnimation(ActionCard actionCard)
    {
        animator.Play(actionCard.animation.name);
        Debug.Log("animation");
    }

    public void performSpawn(ActionCard actionCard)
    {
        Debug.Log("Spawn");
    }

    
}
