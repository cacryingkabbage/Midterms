using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickGrow : MonoBehaviour
{
    public GameObject henPrefab, roosterPrefab;

    //public GameObject counter;

    //calling the invoke
    void Start()
    {
        Invoke("SpawnObject", 10);
        Destroy(gameObject, 10);

        GameManager.Instance.UpdateChickScore(1);
    }

    //instantiates the target object
    void SpawnObject()
    {
        int count = GameManager.ChickCount;
        Vector3 myVector = new Vector3(transform.position.x, 1f, transform.position.z);

        // if there is only one chick then grow into a HEN
        if (count < 2)
        {
            // instantiate hen

            Instantiate(henPrefab, myVector, Quaternion.identity);
        }
        else // OTHERWISE randomize between hen and rooster
        {

            float randomValue = Random.value;

            if (randomValue > 0.3) {
                // instantiate rooster
                Instantiate(roosterPrefab, myVector, Quaternion.identity);
            }
            else
            {
                // instantiate hen
                Instantiate(henPrefab, myVector, Quaternion.identity);
            }
            //Instantiate(henPrefab, transform.position, Quaternion.identity);
            //Instantiate(roosterPrefab, transform.position, Quaternion.identity);
        }
    }
}
