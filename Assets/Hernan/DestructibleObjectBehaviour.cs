using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestructibleObjectBehaviour : MonoBehaviour, IHitabble
{
    public UnityEvent imDie;

    public void ReciveHit()
    {
        imDie.Invoke();
    }
}
