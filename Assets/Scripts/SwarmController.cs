using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwarmController : MonoBehaviour
{
    public GameObject[] prefabs = new GameObject[2];

    public GameObject[] objects;
    float timer = 0.0f;
    public bool spawn = false;

    // Update is called once per frame
    void Update()
    {
        if(spawn == true)
        {
            timer += Time.deltaTime;
            if (timer > 10.0f)
            {
                timer = 0;
                objects = GameObject.FindGameObjectsWithTag("Spawner");
                int randomSpawner = Random.Range(0, objects.Length);
                int randomPrefab = Random.Range(0, prefabs.Length);
                GameObject prefab = prefabs[randomPrefab];

                GameObject target = Instantiate(prefab, objects[randomSpawner].transform.position, objects[randomSpawner].transform.rotation);

                Vector3 direction = transform.position - objects[randomSpawner].transform.position;
                direction.Normalize();
                target.GetComponent<Rigidbody>().velocity = direction * 2.0f;

                // need to destroy zombies after x time
            }
        }
    }
}
