using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeliveryPointSpawner : MonoBehaviour
{
    [SerializeField] public GameObject deliveryPoint;

    [SerializeField] private Button deliveryActiveButton;

    void Start()
    {
        Button btn = deliveryActiveButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Vector3 randomSpawnPoint = new Vector3(Random.Range(-10, 11), -1, Random.Range(-10, 11));
        Instantiate(deliveryPoint, randomSpawnPoint, Quaternion.identity);
    }
    
}
