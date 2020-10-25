using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackTileController : MonoBehaviour
{
    public AudioManager audioManager;

    void OnTriggerEnter(Collider other) // on a collision between this objects rigidbody and another objects rigidbody
    {
        Debug.Log("Track Tile collision detected");
        
        if (other.gameObject.CompareTag("TrainHorn"))
        {
            audioManager.PlayTrainHornClip();
        }
    }
}
