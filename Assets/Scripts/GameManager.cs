using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject mineParent;
    public GameObject cfParent;
    public GameObject xrRigSmall;
    public GameObject xrRigLarge;


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

}
