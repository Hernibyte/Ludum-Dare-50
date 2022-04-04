using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public static PlayerAttack Instance { get; private set; }

    [SerializeField] float interactionDistance;
    [SerializeField] Transform playerCamera;
    [SerializeField] LayerMask interactObj;
    [SerializeField] Animator animator;

    public AudioSource japishSound;

    void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        Debug.DrawRay(playerCamera.position, playerCamera.forward * interactionDistance, Color.red);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.SetBool("golpeo", true);
            japishSound.Play();
        }
    }

    public void Hit()
    {
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, playerCamera.forward, out hit, interactionDistance, interactObj))
        {
            IHitabble hitabble = hit.transform.gameObject.GetComponent<IHitabble>();
            hitabble.ReciveHit();
        }
    }
}
