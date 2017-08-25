using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocarDeCena : MonoBehaviour
{
    public string nomeDaCena = null;

    public void TrocarCena()
    {
        Debug.Log("clicou");   
        UnityEngine.SceneManagement.SceneManager.LoadScene(nomeDaCena);
    }

}
