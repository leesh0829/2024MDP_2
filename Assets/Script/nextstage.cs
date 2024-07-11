using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextstage : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("avoid game2");
    }

    public void finllay()
    {
        SceneManager.LoadScene("avoid game3");
    }
}
