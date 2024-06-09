using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hen : MonoBehaviour
{
    public GameObject eggPrefab;
    //calling the invoke

    public GameObject counter;


    void Start()
    {
        Destroy(gameObject, 40);
        for (int i = 2; i < 11; i++)
        {
            Invoke("SpawnObject", 30);
        }
        //GameManager.henCount += 1; //add 1 to the egg count
        GameManager.Instance.UpdateHenScore(1);
    }

//instantiates the target object
void SpawnObject()
    {
        Vector3 myVector = new Vector3(transform.position.x, 1f, transform.position.z);
        Instantiate(eggPrefab, myVector, Quaternion.identity);
    }

}
