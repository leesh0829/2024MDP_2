using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_button : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("start");
    }
}
