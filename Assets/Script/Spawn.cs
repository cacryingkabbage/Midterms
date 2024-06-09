using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn : MonoBehaviour
{
    public GameObject chickPrefab;
    //calling the invoke

    void Start()
    {
        Invoke("SpawnObject", 10);
        Destroy(gameObject, 10);

        GameManager.Instance.UpdateEggScore(1);

    }


    //instantiates the target object
    void SpawnObject()
    {
        Vector3 myVector = new Vector3(transform.position.x, 1f, transform.position.z);
        Instantiate(chickPrefab, myVector, Quaternion.identity);
    }

}