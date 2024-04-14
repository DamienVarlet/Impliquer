using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Turn : MonoBehaviour
{
    public static int EventRound { get { return eventRound; } }
    static int eventRound = 1;
    public static int Round { get { return round; } }
    static int round = 0;
    public Button buttonStartRound;
    public static string Player { get { return player; } }
    static string player = "Agent";
    public TextMeshProUGUI playerTurn;

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    void StartRound()
    {
        switch (player)
        {
            case "Agent":
                round += 1;
                if(round == 4)
                {
                    round = 1;
                    eventRound += 1;
                }
                player = "Royalist";
                LoadScene("AgentsScene");
            break;
            case "Royalist":
                player = "Agent";
                LoadScene("RoyalistScene");
            break;
        }
    }
    void Start()
    {
        buttonStartRound = GameObject.Find("buttonStartRound").GetComponent<Button>();
        buttonStartRound.onClick.AddListener(StartRound); 
        if(player == "Agent")  
        {
            playerTurn.text = "Tour des Agents"; 
        }
        if(player == "Royalist")  
        {
            playerTurn.text = "Tour des Royalistes"; 
        }
    }

    void Update()
    {
        
    }
}
