using System.Collections;
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
        if (other.gameObject.CompareTag("JumpScare"))
        {
            gameManager.JumpScare();
        }
        if (other.gameObject.CompareTag("JumpScareFinish"))
        {
            gameManager.JumpScareFinish();
        }
        if (other.gameObject.CompareTag("LightsOff"))
        {
            Debug.Log("Tile lights off");
            gameManager.LightsOff();
        }
        if (other.gameObject.CompareTag("LightsOn"))
        {
            gameManager.LightsOn();
        }
        if (other.gameObject.CompareTag("TenseMusic"))
        {
            gameManager.TenseMusic();
        }
        if (other.gameObject.CompareTag("WitchCackle"))
        {
            gameManager.WitchCackle();
        }
        if (other.gameObject.CompareTag("Swarm"))
        {
            gameManager.ZombieSwarmOn();
        }
        if (other.gameObject.CompareTag("SwarmOff"))
        {
            gameManager.ZombieSwarmOff();
        }
    }
}
