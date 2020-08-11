﻿using UnityEngine;

public class GoldCoins : MonoBehaviour {

    public float amount = 10f;

    private Score score;

    private void Start(

    ) {
        score = FindObjectOfType<Score>();
    }

    private void OnTriggerEnter(

    ) {
        score.AddCoin(amount);
        gameObject.SetActive(false);
    }
}
