using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_button : MonoBehaviour
{
   public void SceneChange()
    {
        SceneManager.LoadScene("avoid game");
    }

    public void infinite()
    {
        SceneManager.LoadScene("infinite");
    }
}
