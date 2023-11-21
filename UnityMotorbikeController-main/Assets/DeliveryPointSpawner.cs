using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeliveryPointSpawner : MonoBehaviour
{
    [SerializeField] public GameObject deliveryPoint;

    

    public int limit = 4;

    int points;

    void Start()
    {
        
        InvokeRepeating("SpawnDeliveryPoint", 5f, 5f);
    }


    void SpawnDeliveryPoint()
    {
        if (points < limit)
        {
            Vector3 randomSpawnPoint = new Vector3(Random.Range(-10, 11), -1, Random.Range(-10, 11));
            Instantiate(deliveryPoint, randomSpawnPoint, Quaternion.identity);
            points++;
        }

    }

    public void Pickup()
    {
        points--;
    }
    
}
