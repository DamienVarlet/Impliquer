using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayCard : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
        public void OnButtonClick()
    {
        Debug.Log("bouton cliqué!");
        
        LoadScene("Game");      
    }
    void Start()
    {
        button1 = GameObject.Find("button1").GetComponent<Button>();
        button1.onClick.AddListener(OnButtonClick);

        button2 = GameObject.Find("button2").GetComponent<Button>();
        button2.onClick.AddListener(OnButtonClick);

        button3 = GameObject.Find("button3").GetComponent<Button>();
        button3.onClick.AddListener(OnButtonClick);

        button4 = GameObject.Find("button4").GetComponent<Button>();
        button4.onClick.AddListener(OnButtonClick);

        button5 = GameObject.Find("button5").GetComponent<Button>();
        button5.onClick.AddListener(OnButtonClick);


    }
    void Update()
    {
        
    }
}
