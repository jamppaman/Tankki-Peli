using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject prefab1;
    //public GameObject prefab2;

    public int createAmount1 = 3;

    void Start()
    {
        for (int i = 0; i < createAmount1; i++) 
        {
            float randX = Random.Range(-32f, 32f);
            float randZ = Random.Range(-32f, 32f);
            Instantiate(prefab1, new Vector3(randX, 0, randZ), Quaternion.identity);
        }
    }


}
