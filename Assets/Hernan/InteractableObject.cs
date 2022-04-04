using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour, IHitabble
{
    public UnityEvent imDie;

    public void ReciveHit()
    {
        imDie.Invoke();
    }
}
