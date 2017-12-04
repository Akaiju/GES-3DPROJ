using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IActivatable
{

    private Animator animator;

    public string NameText
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
            throw new System.NotImplementedException();
        }
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void DoActivate()
    {
        animator.SetBool("isOpen", true);

    }
}
