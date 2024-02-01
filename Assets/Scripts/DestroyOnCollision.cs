using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    [SerializeField] string name;
    private void OnCollisionEnter(Collision collision)
    {
        if (name =="Tomato")
        {
            AudioManager.instance.PlayOneshotSFX(AudioManager.AudioSamples.tomatoSplash);
        }
        Destroy(gameObject);
    }
}
