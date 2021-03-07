using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemiesmovement : MonoBehaviour
{   
     float speed = 1f;
    public float PositionMax;
    public float PositionMin;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
        if (transform.position.x >= PositionMax)
        {
            speed = -speed;
            sr.flipX = true;
        }
        else if (transform.position.x <= PositionMin)
        {
            speed = -speed;
            sr.flipX = false;
        }
    }
}
