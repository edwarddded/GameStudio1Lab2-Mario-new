﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MarioCollision : MonoBehaviour
{
    private Vector3 scaleChange;

    SpriteRenderer sr;

    float health = 3;
    public Text healthText;

    public Text CoinText;
    float value = 200;
    float Coinscore = 0;
    private void Start()
    {
        scaleChange = new Vector3(1.5f, 2f, 2f);
        sr = gameObject.GetComponent<SpriteRenderer>();
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            Coinscore += value;

            CoinText.text = "Coin Score:" + Coinscore.ToString();
            Debug.Log(Coinscore);
            Debug.Log(other.name);
        }
        if (other.gameObject.tag == "Star")
        {
            Destroy(other.gameObject);
            sr.color = new Color(1,0,0,1);
            Debug.Log(other.name);
        }
        if (other.gameObject.tag == "Mushroom")
        {
            Destroy(other.gameObject);
            gameObject.transform.localScale = scaleChange;
            Debug.Log(other.name);
        }
        if (other.gameObject.tag == "Enemy")
        {
            health--;
            healthText.text = "Health X" + health.ToString();
            if (health ==0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            
            Debug.Log(other.name);
        }
    }
}
