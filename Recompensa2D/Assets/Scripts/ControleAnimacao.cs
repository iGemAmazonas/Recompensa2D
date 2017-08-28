using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleAnimacao : MonoBehaviour
{
    public Animator anim;
    private bool estado;

    public void StartClick ()
    {
        estado = true;

        MudarEstado(estado);        
    }

    public void PauseClick()
    {
        estado = false;
        MudarEstado(estado);
    }

    private void MudarEstado(bool estado)
    {
        anim.SetBool("Estado", estado);
    }


}
