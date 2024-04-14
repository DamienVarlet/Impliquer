using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Gauge : MonoBehaviour
{
    static int jaugePolitique = 100;
    static int jaugeNoblesse = 100;
    static int jaugeMilitaire = 100;
    int jaugePolitiqueA = Agents.JaugePolitiqueA;
    int jaugeNoblesseA = Agents.JaugeNoblesseA;
    int jaugeMilitaireA = Agents.JaugeMilitaireA;
    int jaugePolitiqueR = Royalists.JaugePolitiqueR;
    int jaugeNoblesseR = Royalists.JaugeNoblesseR;
    int jaugeMilitaireR = Royalists.JaugeMilitaireR;
    public TextMeshProUGUI gauge;
    string player = Turn.Player;
    void Start()
    {
        Debug.Log("Player : " + player);
        if(player == "Royalist")
        {
            switch(gauge.gameObject.name){
                case "political gauge":
                    jaugePolitique += jaugePolitiqueA;
                    gauge.text = "Jauge politique : " + jaugePolitique;
                break;
                case "nobility gauge":
                    jaugeNoblesse += jaugeNoblesseA;
                    gauge.text = "Jauge noblesse : " + jaugeNoblesse;
                break;
                case "military gauge":
                    jaugeMilitaire += jaugeMilitaireA;
                    gauge.text = "Jauge militaire : " + jaugeMilitaire;
                break;
            }
        }
        if(player == "Agent")
        {
            switch(gauge.gameObject.name){
                case "political gauge":
                    jaugePolitique -= jaugePolitiqueR;
                    gauge.text = "Jauge politique : " + jaugePolitique;
                break;
                case "nobility gauge":
                    jaugeNoblesse -= jaugeNoblesseR;
                    gauge.text = "Jauge noblesse : " + jaugeNoblesse;
                break;
                case "military gauge":
                    jaugeMilitaire -= jaugeMilitaireR;
                    gauge.text = "Jauge militaire : " + jaugeMilitaire;
                break;
            }
        }
    }

    void Update()
    {
        
    }
}
