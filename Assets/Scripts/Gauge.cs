using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Gauge : MonoBehaviour
{
    int politique = Agents.JaugePolitique;
    int noblesse = Agents.JaugeNoblesse;
    int militaire = Agents.JaugeMilitaire;
    public TextMeshProUGUI gauge;
    void Start()
    {
        switch(gauge.gameObject.name){
            case "political gauge":
                gauge.text = "Jauge politique : " + politique;
            break;
            case "nobility gauge":
                gauge.text = "Jauge noblesse : " + noblesse;
            break;
            case "military gauge":
                gauge.text = "Jauge militaire : " + militaire;
            break;
        }
    }

    void Update()
    {
        
    }
}
