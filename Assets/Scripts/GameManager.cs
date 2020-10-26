using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject mineParent;
    public GameObject cfParent;


    public void DisableCandyForrest()
    {
        Debug.Log("CF enable");
        GameObject.FindGameObjectWithTag("CandyForrestParent").SetActive(false);
    }

    public void EnableCandyForrest()
    {
        Debug.Log("CF disable");
        cfParent.SetActive(true);
    }

    public void DisableMine()
    {
        Debug.Log("Mine disable");
        GameObject.FindGameObjectWithTag("MineParent").SetActive(false);
    }

    public void EnableMine()
    {
        Debug.Log("Mine enable");
        mineParent.SetActive(true);
    }

}
