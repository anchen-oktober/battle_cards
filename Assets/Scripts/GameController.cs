﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    static public GameController instance = null;
    public Deck playerDeck = new Deck();
    public Deck enemyDeck  = new Deck();

    public Hand playersHand = new Hand();
    public Hand enemysHand  = new Hand();
    
    public List<CardData> cards = new List<CardData>();
        
    public Sprite[] healthNumbers = new Sprite[10];
    public Sprite[] damageNumbers = new Sprite[10];

    public GameObject cardPrefub = null;
    public Canvas canvas         = null;

    public bool isPlayable = false;
    
    private void Awake()
    {
        instance = this;

        playerDeck.Create();
        enemyDeck.Create();

        StartCoroutine(DealHands());
    }
    
    public void Quit()
    {        
        SceneManager.LoadScene(0);
    }

    public void ScipTurn()
    {
        Debug.Log("ScipTurn button pressed");

    }

    internal IEnumerator DealHands()
    {
        yield return new WaitForSeconds(1);
        for (int t=0;t<3;t++)
        {
            playerDeck.DealCard(playersHand);
            enemyDeck.DealCard(enemysHand);
            yield return new WaitForSeconds(1);
        }
        isPlayable = true;
    }
}
