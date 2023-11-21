using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsSystem : MonoBehaviour
{
    public int pointsNumber = 0;
    [SerializeField] public Text pointsText;

    public int deliviriesNumber = 0;
    [SerializeField] public Text deliviriesText;

    [SerializeField] public GameObject deliveryPoint;

    public DeliveryPointSpawner spawner;

    private void Start()
    {
        pointsText.GetComponent<Text>();
        deliviriesText.GetComponent<Text>();
        
    }

    private void Update()
    {
       pointsText.text = pointsNumber.ToString();
       deliviriesText.text = deliviriesNumber.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Points")
        {
            spawner.Pickup();
            
            pointsNumber += UnityEngine.Random.Range(5, 16);
            deliviriesNumber++;
            
            Destroy(other.gameObject);

        }
        

        
    }
}
