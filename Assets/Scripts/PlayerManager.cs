using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public ActionCard actionCard;

    public Animator animator;

    public GameObject spawnObject;


    public void Start()
    {
        AbilitieManager.instance.OnActionPerformRagdoll += performRagdoll;
        AbilitieManager.instance.OnActionPerformAnim += performAnimation;
        AbilitieManager.instance.OnActionPerformSpawn += performSpawn;
    }

    public void performAnimation(ActionCard actionCard)
    {
        Debug.Log("Animacion");
    }

    public void performSpawn(ActionCard actionCard)
    {
        Debug.Log("Spawn");
    }

    public void performRagdoll(ActionCard actionCard)
    {
        Debug.Log("Ragdoll");
    }
}
