using System.Collections;
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

     public AudioSource CoinPlay;
     public AudioSource MushroomPlay;
   

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

            CoinPlay.Play();
            Debug.Log(Coinscore);
            Debug.Log(other.name);
        }
        if (other.gameObject.tag == "Star")
        {
            Destroy(other.gameObject);
            //sr.color = new Color(1, 0, 0, 1);
            health++;
            healthText.text = "Health X" + health.ToString();
            MushroomPlay.Play();
            Debug.Log(other.name);
        }
        if (other.gameObject.tag == "Mushroom")
        {
            Destroy(other.gameObject);
            MushroomPlay.Play();
            gameObject.transform.localScale = scaleChange;
            Debug.Log(other.name);
        }
        if (other.gameObject.tag == "Enemy")
        {
            health--;
            healthText.text = "Health X" + health.ToString();
            if (health == 0)
            {
                SceneManager.LoadScene(2);
            }

            Debug.Log(other.name);
        }
            
        
        if (other.gameObject.tag == "Black")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (other.gameObject.tag == "Win")
        {
            SceneManager.LoadScene(3);
        }
    }
}
