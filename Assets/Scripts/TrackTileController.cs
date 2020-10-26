﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackTileController : MonoBehaviour
{
    public AudioManager audioManager;
    public AudioSource audioSource;
    public GameManager gameManager;
    Rigidbody rb;
    public float thrust = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other) // on a collision between this objects rigidbody and another objects rigidbody
    {
        if (other.gameObject.CompareTag("TrainHorn"))
        {
            audioManager.PlayTrainHornClip();
        }
        if (other.gameObject.CompareTag("DisableCF"))
        {
            gameManager.DisableCandyForrest();
        }
        if (other.gameObject.CompareTag("EnableCF"))
        {
            gameManager.EnableCandyForrest();
        }
        if (other.gameObject.CompareTag("EnableMine"))
        {
            gameManager.EnableMine();
        }
        if (other.gameObject.CompareTag("DisableMine"))
        {
            gameManager.DisableMine();
        }
        if (other.gameObject.CompareTag("XRRig"))
        {
            gameManager.ChangeToLargeRig();
            audioSource.Stop();
            rb.isKinematic = false;
            rb.AddForce(transform.forward * thrust);
        }
    }
}
