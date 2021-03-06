using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemiesmovement : MonoBehaviour
{   
     float speed = 5f;
    public float PositionMax;
    public float PositionMin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
        if (transform.position.x >= PositionMax)
        {
            speed = -speed;

        }
        else if (transform.position.x <= PositionMin)
        {
            speed = -speed;

        }
    }
}
