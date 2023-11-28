using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button quitButton;

    // Start is called before the first frame update
    void Start()
    {
       playButton.onClick.AddListener(() => SceneManager.LoadScene("CharacterSelectScene"));

       quitButton.onClick.AddListener(() => Application.Quit());
    }

    
}
