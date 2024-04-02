using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public string Game;
    public Button button;
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void OnButtonClick()
    {
        LoadScene(Game); 
        //Debug.Log("Bouton cliqué");
    }
    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("Button").GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
