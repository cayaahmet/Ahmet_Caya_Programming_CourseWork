using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TimerUI : MonoBehaviour
{
    public float timer = 60;
    [SerializeField] public TMP_Text timerText;

    private void Start()
    {
        timerText.GetComponent<Text>();
    }

    private void Update()
    {
       timer -= Time.deltaTime;
       timerText.text = timer.ToString("F2");

       if (timer < 0) 
       {
         SceneManager.LoadScene("Motorbike");
       }
    }
}
