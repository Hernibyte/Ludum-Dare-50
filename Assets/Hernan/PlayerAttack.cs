using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] float interactionDistance;
    [SerializeField] Transform playerCamera;
    [SerializeField] LayerMask destructibleObject_LayerMask;

    void Update()
    {
        Debug.DrawRay(playerCamera.position, playerCamera.forward * interactionDistance, Color.red);
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, playerCamera.forward, out hit, interactionDistance, destructibleObject_LayerMask))
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
