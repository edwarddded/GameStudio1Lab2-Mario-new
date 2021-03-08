using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagHit : MonoBehaviour
{
   public Animator animator;
    // Start is called before the first frame update
   public  AudioClip flag;
    public AudioSource flagsource;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Mario")
        {
            animator.SetBool("IsHitting", true);
            flagsource.clip = flag;
            flagsource.Play();
        }
    }
}
