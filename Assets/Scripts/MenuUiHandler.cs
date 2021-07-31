using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUiHandler : MonoBehaviour
{
    public string input;
    public TextMeshProUGUI userName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMainScene(string scenename)
    {
        Debug.Log("sceneName to load: " + scenename);
        SceneManager.LoadScene(scenename);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("ExitGame");
    }

    public void GetInputString(string s)
    {
        userName.text = s + "'s Best Score: ";
        //MainManager.Instance.ScoreText.text = userName.text;
        MenuManager.Instance.nameText.text = userName.text;
        input = s;
        Debug.Log("Input: " + userName.text);
    }
}
