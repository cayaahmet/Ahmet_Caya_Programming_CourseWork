using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsSystem : MonoBehaviour
{
    public int pointsNumber = 0;
    [SerializeField] public Text pointsText;

    /// <summary>
    /// [SerializeField] GameObject Player;
    /// </summary>

    [SerializeField] public GameObject deliveryPoint;

    private void Start()
    {
        pointsText.GetComponent<Text>();
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
            pointsNumber++;
            //pointsNumber = UnityEngine.Random.Range(5, 15);
            
            //Destroy(deliveryPoint.gameObject);


        }
        //pointsText.text = pointsText.ToString();

        
    }
}
