﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleAnimacao : MonoBehaviour
{
    public Animator anim;
    private bool controle;

    public void StartClick ()
    {
        if(controle==false)
        {
            controle = true;
        }

        mudarEstado(controle);        
    }

    private void mudarEstado(bool estado)
    {
        anim.SetTrigger("Vai");
        //anim.SetBool("Começar", estado);
        
    }


}
