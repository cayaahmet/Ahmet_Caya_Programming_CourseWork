using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongScript : MonoBehaviour
{
    public event EventHandler DeliveryPointSpawned;
    public event EventHandler DeliveryPointReached;

    [SerializeField] public GameObject deliveryPoint;

    private float spawnTimer;
    private float spawnTimerMax = 4f;
    private int spawnedAmount;
    private int spawnedAmountMax = 8;
    
    [SerializeField] private Transform deliverySpawner;

    private List<GameObject> visualGameObjectList;

    [SerializeField] private Transform randomPoint;

    private void Awake()
    {
        visualGameObjectList = new List<GameObject>();
    }

    private void Start()
    {
        DeliveryPointSpawned += Delivery_PointSpawned;
        DeliveryPointSpawned += Delivery_OnPointSpawned;

    }

    private void Delivery_PointSpawned(object sender, System.EventArgs e)
    {
        GameObject deliveryGameObject = visualGameObjectList[visualGameObjectList.Count - 1];
        visualGameObjectList.Remove(deliveryGameObject);
        Destroy(deliveryGameObject);
    }

    private void Delivery_OnPointSpawned(object sender, System.EventArgs e)
    {
        Transform deliveryVisualTransform = Instantiate(deliverySpawner, randomPoint);

        float plateOffset = .1f;
        deliveryVisualTransform.localPosition = new Vector3(0, plateOffset * visualGameObjectList.Count, 0);

        visualGameObjectList.Add(deliveryVisualTransform.gameObject);
    }

    private void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer > spawnTimerMax)
        {
            spawnTimer = 0;

            if (spawnedAmount < spawnedAmountMax)
            {
                spawnedAmount++;

                DeliveryPointSpawned?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}


