using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Scene mazeScene;
    public Button playButton;
    public Button quitButton;
    public Button optionsButton;
    public Button backButton;

    public GameObject mainMenu;
    public GameObject optionsMenu;

    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(PlayMaze);
        quitButton.onClick.AddListener(QuitMaze);
        optionsButton.onClick.AddListener(OptionsMenuOpen);
        backButton.onClick.AddListener(MainMenuOpen);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayMaze()
    {
        SceneManager.LoadScene("maze");
    }

    public void QuitMaze()
    {
        Debug.Log("Quit Game");
    }

    public void OptionsMenuOpen()
    {
        optionsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void MainMenuOpen()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }
}
