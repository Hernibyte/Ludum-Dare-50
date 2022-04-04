using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestructibleObjectBehaviour : MonoBehaviour, IHitabble
{
    [SerializeField] GameObject rotoModel;
    public UnityEvent imDie;

    public AudioSource plateSound;
    public AudioSource multiplePlateSound;
    public AudioSource vasijaSound;
    public AudioSource teleSound;

    public void ReciveHit()
    {  
        imDie.Invoke();
        Instantiate(rotoModel, transform.position, Quaternion.identity);

        if (tag == "Plate")
            plateSound.Play();
        else if(tag == "MultiPlate")
            multiplePlateSound.Play();
        else if (tag == "Vasija")
            vasijaSound.Play();
        else if (tag == "Tele")
            teleSound.Play();

        Destroy(gameObject);
    }
}
