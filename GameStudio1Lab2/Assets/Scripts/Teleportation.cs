using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public GameObject Portal, player;
    // Start is called before the first frame update
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Mario")
        {
            StartCoroutine(Teleport());
        }
    }
    
    IEnumerator Teleport()
    {
        yield return new WaitForSeconds(1);
        player.transform.position = new Vector2(Portal.transform.position.x, Portal.transform.position.y);
    }
}
