using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMotionList : MonoBehaviour
{
    public List<string> motionList = new List<string>();
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Animator animator = other.gameObject.GetComponent<Animator>();
            RuntimeAnimatorController ac = animator.runtimeAnimatorController;
            motionList.Add(ac.animationClips[0].name);
            Debug.Log(ac.animationClips[0].name);        

            Destroy(other.gameObject);
        }
    }
}
