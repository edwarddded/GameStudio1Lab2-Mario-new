using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionBlock : MonoBehaviour
{
    public GameObject questionBlock;
    public GameObject emptyBlock;
    public GameObject itemPickup;


    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.tag == "Mario") 
        {
            Debug.Log("Collision detected with Mario");

            if (itemPickup.tag == "Mushroom") 
            {
     
                
                Debug.Log("Item Spawned");
                Instantiate(itemPickup, transform.position + new Vector3(0f, 0.15f, 0f), transform.rotation);
            }
            if (itemPickup.tag == "Star")
            {
                
                Debug.Log("Item Spawned");
                Instantiate(itemPickup, transform.position + new Vector3(0f, 0.15f, 0f), transform.rotation);
            }
            if (itemPickup.tag == "Coin")
            {
                Debug.Log("Item Spawned");
                Instantiate(itemPickup, transform.position + new Vector3(0f, 0.15f, 0f), transform.rotation);
            }

            Instantiate(emptyBlock, transform.position, transform.rotation);
            Destroy(gameObject.transform.parent.gameObject);
        }
    }

}
