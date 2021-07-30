using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUiHandler : MonoBehaviour
{
    public string input;
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
        input = s;
        Debug.Log("Input: " + input);
    }
}
