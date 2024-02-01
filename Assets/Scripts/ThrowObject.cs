using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObject : MonoBehaviour
{

    [SerializeField] Transform pointSpawn;
    [SerializeField] GameObject chicken,Tomato;
    [SerializeField] float objectSpeed;
    //Los Segundos de espera para spawnear no funcionan.
    [SerializeField] int secondsForSpawn;
  
    public void ThrowChicken()
    {
        StartCoroutine(WaitAnim(secondsForSpawn));
        var Chicken = Instantiate(chicken, pointSpawn.position, Quaternion.Euler(-90, 0, 0));
        Chicken.GetComponent<Rigidbody>().velocity = objectSpeed * pointSpawn.forward;
    }
    public void ThrowTomato()
    {
        
        StartCoroutine(WaitAnim(secondsForSpawn));
        var tomato = Instantiate(Tomato, pointSpawn.position, Quaternion.Euler(-90,0,0));
        tomato.GetComponent<Rigidbody>().velocity = pointSpawn.forward*objectSpeed;
    }
    public static IEnumerator WaitAnim(int seconds)
    {
        yield return new WaitForSeconds(seconds);
        
    }
}

