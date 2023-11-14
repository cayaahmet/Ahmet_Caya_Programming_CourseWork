using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsSystem : MonoBehaviour
{
    public int pointsNumber = 0;
    [SerializeField] public Text pointsText;

    [SerializeField] public GameObject deliveryPoint;

    private void Start()
    {
        pointsText.GetComponent<Text>();
        deliveryPoint.GetComponent<GameObject>();
    }

    private void Update()
    {
       pointsText.text = pointsNumber.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Points")
        {
            Debug.Log("1");
            
            pointsNumber += UnityEngine.Random.Range(5, 16);
            
            Destroy(other.gameObject);

        }
        

        
    }
}
