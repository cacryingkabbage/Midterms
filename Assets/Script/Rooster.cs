using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rooster : MonoBehaviour
{
    public GameObject counter;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 40);
        GameManager.Instance.UpdateRoosterScore(1);
        //GameManager.roosterCount += 1; //add 1 to the egg count
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
