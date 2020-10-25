using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackTileController : MonoBehaviour
{
    public AudioManager audioManager;

    void OnTriggerEnter(Collider other) // on a collision between this objects rigidbody and another objects rigidbody
    {
        Debug.Log("Collision detected");
        
        if (other.gameObject.CompareTag("Train"))
        {
            Debug.Log("PLayer collision detected");
            audioManager.PlayTrainHornClip();
        }
    }
}
