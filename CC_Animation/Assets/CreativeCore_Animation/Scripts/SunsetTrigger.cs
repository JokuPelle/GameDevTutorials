using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunsetTrigger : MonoBehaviour
{
    public Animator anim;
    private void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("SunsetTrigger");
    }
    private void OnTriggerExit(Collider other)
    {
        anim.SetTrigger("SunsetTrigger");
    }
}
