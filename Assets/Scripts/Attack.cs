﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CharacterAttack()
    {
        anim.SetTrigger("isClicked");
    }
}
