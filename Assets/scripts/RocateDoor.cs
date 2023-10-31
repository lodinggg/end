using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocateDoor : MonoBehaviour
{
    public Animator animator;
    public Animator animator1;
    public Animator animator2;
    public Animator animator3;
    public GameObject main;
    public GameObject charter;
    public GameObject pan;
    public GameObject sta;
    public GameObject player;
    public GameObject intro;
    public void Update()
    {
        if (Input.anyKeyDown)
        {
            animator.SetTrigger("IsOpen");
            animator1.SetTrigger("IsOpen");
            animator2.SetTrigger("IsCam");
            Invoke("cam", 2.1f);
            Invoke("cam2", 1.3f);
            pan.SetActive(false);
        }
    }

    public void cam()
    {
        main.SetActive(false);
        charter.SetActive(true);
        intro.SetActive(false);
    }
    public void cam2()
    {
        player.GetComponent<mouse>().enabled = true;
        animator3.SetTrigger("IsChange");
    }

    
}
