using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovement : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
         if (other.tag == "Door1")
        {
            Animator anim = other.GetComponentInChildren<Animator>();
            if (Input.GetKeyDown(KeyCode.E))
                anim.SetTrigger("OpenClose");
        }
    }

}
