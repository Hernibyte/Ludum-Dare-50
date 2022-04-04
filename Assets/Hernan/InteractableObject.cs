using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour, IHitabble
{
    public UnityEvent imDie;

    public AudioSource maderaSound;

    public void ReciveHit()
    {
        imDie.Invoke();
        if (tag == "Madera")
            maderaSound.Play();
    }
}
