using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestructibleObjectBehaviour : MonoBehaviour, IHitabble
{
    //[SerializeField] GameObject rotoModel;
    public UnityEvent imDie;

    public void ReciveHit()
    {
        imDie.Invoke();
        //Instantiate(rotoModel, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
