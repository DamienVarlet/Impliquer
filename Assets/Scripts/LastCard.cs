using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastCard : MonoBehaviour
{
    string playedCardA = Agents.PlayedCardA;
    string playedCardR = Royalists.PlayedCardR;
    string player = Turn.Player;
    void DisplayCard(string cardName, int posX)
    {
        GameObject card = GameObject.Find(cardName);
        Vector2 position = card.transform.position;
        Vector2 scale = card.transform.localScale;

        position.x = posX;
        position.y = 0;
        scale.x = 0.3f;
        scale.y = 0.3f;

        card.transform.position = position;
        card.transform.localScale = scale;
        card.GetComponent<Renderer>().enabled = true;
    }
    void Start()
    {
        switch(player)
        {
            case "Agent":
                if(playedCardR != null)
                {
                    DisplayCard(playedCardR, -9);
                }
            break;
            case "Royalist":
                if(playedCardA != null)
                {
                    DisplayCard(playedCardA, -9);
                } 
            break;
        }
    }

    void Update()
    {
        
    }
}
