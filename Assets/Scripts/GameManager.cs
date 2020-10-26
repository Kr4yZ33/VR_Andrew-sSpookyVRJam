using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public SwarmController swarmController;
    public AudioManager audioManager;
    public GameObject mineParent;
    public GameObject cfParent;
    public GameObject xrRigSmall;
    public GameObject xrRigLarge;
    public GameObject zombie;
    public GameObject cameraBlackout;

    public void DisableCandyForrest()
    {        
        cfParent.SetActive(false);
    }

    public void EnableCandyForrest()
    {
        cfParent.SetActive(true);
    }

    public void DisableMine()
    {
        mineParent.SetActive(false);
    }

    public void EnableMine()
    {
        mineParent.SetActive(true);
    }
    public void ChangeToLargeRig()
    {
        xrRigSmall.SetActive(false);
        xrRigLarge.SetActive(true);
    }
    public void ChangeToSmallRig()
    {
        xrRigLarge.SetActive(false);
        xrRigSmall.SetActive(true);
    }
    public void JumpScare()
    {
        zombie.SetActive(true);
    }

    public void JumpScareFinish()
    {
        zombie.SetActive(false);
    }

    public void LightsOn()
    {
        cameraBlackout.SetActive(true);
    }

    public void LightsOff()
    {
        Debug.Log("Lights off");
        cameraBlackout.SetActive(false);
    }

    public void TenseMusic()
    {
        audioManager.PlayTenseMusic();
    }

    public void WitchCackle()
    {
        audioManager.PlayWitchCackle();
    }

    public void ZombieSwarmOn()
    {
        swarmController.spawn = true;
    }

    public void ZombieSwarmOff()
    {
        swarmController.spawn = false;
    }
}
