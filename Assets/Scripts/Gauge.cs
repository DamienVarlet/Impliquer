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
    void Start()
    {
        switch(gauge.gameObject.name){
            case "political gauge":
                jaugePolitique = jaugePolitique + jaugePolitiqueA - jaugePolitiqueR;
                gauge.text = "Jauge politique : " + jaugePolitique;
            break;
            case "nobility gauge":
                jaugeNoblesse = jaugeNoblesse + jaugeNoblesseA - jaugeNoblesseR;
                gauge.text = "Jauge noblesse : " + jaugeNoblesse;
            break;
            case "military gauge":
                jaugeMilitaire = jaugeMilitaire + jaugeMilitaireA - jaugeMilitaireR;
                gauge.text = "Jauge militaire : " + jaugeMilitaire;
            break;
        }
    }

    void Update()
    {
        
    }
}
