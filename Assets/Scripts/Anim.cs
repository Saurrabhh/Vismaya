using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    void Awake()
    {
        anim = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Walk(bool walk)
    {
        anim.SetBool("Walk", walk);
    }

    public void JumpAnim()
    {
        anim.SetTrigger("Jump");
    }
}
