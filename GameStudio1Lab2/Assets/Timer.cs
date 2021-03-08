using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    float timer = 400f;
    public Text time;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        time.text = "Time:" + timer.ToString("0");
        if (timer < 0f)
        {
            SceneManager.LoadScene(2);
        }
    }
}
