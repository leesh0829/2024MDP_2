using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//플레이어 채력 컨드롤 등등...
public class PlayerCounter : MonoBehaviour
{
    public int PlayerHealth = 3;
    // Start is called before the first frame update
    public void TakeDamage()
    {
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