﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class staty : MonoBehaviour
{
    public static int iloscDrzew;
    public static int miesiac, miesiaceGry, iloscNawozu, iloscPieniedzy, cenaDrzewa, cenaNawozu, iloscPestycydu, cenaPestycydu;
    public Text statsText;
    public bool czyScieloDrzewo = false;

    // Start is called before the first frame update
    void Start()
    {
        iloscDrzew = 1;
        miesiac = 0;
        iloscNawozu = 0;
        iloscPestycydu = 0;
        iloscPieniedzy = 80;

        miesiaceGry = 60;
        
        statsText.text = "Trees: " + iloscDrzew + ", Coins: " + iloscPieniedzy + ", Fertilizers: " + iloscNawozu + ", Pesticides: " + iloscPestycydu + ", Month: " + miesiac % 12 + ", Year: " + miesiac / 12 + ", Remains: " + (miesiaceGry - miesiac) + " months";
    }

    // Update is called once per frame
    void Update()
    {
        statsText.text = "Trees: " + iloscDrzew + ", Coins: " + iloscPieniedzy + ", Fertilizers: " + iloscNawozu + ", Pesticides: " + iloscPestycydu + ", Month: " + miesiac % 12 + ", Year: " + miesiac / 12 + ", Remains: " + (miesiaceGry - miesiac) + " months";
        
    }

    public void cennikDrzewa()
    {
        cenaDrzewa = Random.Range(1000, 2500);        
    }

    public void cennikNawozu()
    {
        cenaNawozu = Random.Range(200, 400);
    }

    public void cennikPestycydu()
    {
        cenaPestycydu = Random.Range(40, 60);
    }        
}
