using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PointsSystem : MonoBehaviour
{
    public int pointsNumber = 0;
    [SerializeField] public Text pointsText;

    public int deliviriesNumber = 0;
    [SerializeField] public Text deliviriesText;

    [SerializeField] public GameObject deliveryPoint;

    [SerializeField] Text highScoreText;

    public DeliveryPointSpawner spawner;

    private void Start()
    {
        pointsText.GetComponent<Text>();
        deliviriesText.GetComponent<Text>();
        CheckHighScore();
        UpdateHighScoreText();


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
            CheckHighScore();
            UpdateHighScoreText(); 
            

        }
        

        
    }

    void CheckHighScore()
    {
        if (pointsNumber > PlayerPrefs.GetInt("High Score: ",0))
        {
            PlayerPrefs.SetInt("High Score: ", pointsNumber);
        }

    }

    void UpdateHighScoreText()
    {
        highScoreText.text = $"High Score:  {PlayerPrefs.GetInt("High Score: ",pointsNumber)}";
    }
}
