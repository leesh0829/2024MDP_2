using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//플레이어 채력 컨드롤 등등...
public class PlayerCounter : MonoBehaviour
{
    private int PlayerHealth = 3;
    private bool[] heartcontroller = { true, true, true };
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    // Start is called before the first frame update
    public void TakeDamage()
    {
        if (heartcontroller[0] == false && heartcontroller[1] == false && heartcontroller[2] == true)
        {
            GameObject.Destroy(Heart3);
            heartcontroller[2] = false;
            Debug.Log("3");
        }

        if (heartcontroller[0] == false && heartcontroller[1] == true && heartcontroller[2] == true)
        {
            GameObject.Destroy(Heart2);
            heartcontroller[1] = false;
            Debug.Log("2");
        }

        if (heartcontroller[0] == true && heartcontroller[1] == true && heartcontroller[2] == true)
        {
            Destroy(Heart1);
            heartcontroller[0] = false;
            Debug.Log("1");
        }

        PlayerHealth--;

        if (PlayerHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        //임시 설정
        Destroy(gameObject);


        //씬 전환 넣기
    }
}