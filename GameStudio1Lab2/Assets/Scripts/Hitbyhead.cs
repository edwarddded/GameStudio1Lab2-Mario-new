using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbyhead : MonoBehaviour
{
    float delay = 0.5f;
    public Animator animator;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Mario")
        {
            animator.SetBool("isHitting",true);

            Destroy(gameObject.transform.parent.gameObject, gameObject.transform.parent.gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);
        }
    }
}
