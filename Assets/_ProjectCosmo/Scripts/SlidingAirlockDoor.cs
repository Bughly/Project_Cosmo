using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingAirlockDoor : MonoBehaviour
{
    public Animator slidingAirlockAnim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            slidingAirlockAnim.SetTrigger("Open");
            Debug.Log("Door Open");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        { 
            slidingAirlockAnim.SetTrigger("Close");
            Debug.Log("Door Closed");
        }
        
    }
}
