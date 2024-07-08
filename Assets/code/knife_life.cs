using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife_life : MonoBehaviour
{
    public GameObject player;
    public float knife_Delay = 5f;
    public float speed = 3f;  // 이동 속도

    private Vector2 moveDirection;
    private bool hasTarget = false;
    private PlayerCounter playerHealth;

    void Awake()
    {
        if (player == null)
        {
            //플레이어 찾기
            player = GameObject.FindGameObjectWithTag("Player");
        }

        if (player != null)
        {
            // 플레이어의 Health 컴포넌트를 찾기
            playerHealth = player.GetComponent<PlayerCounter>();

            // 플레이어 위치 저장
            Vector2 targetPosition = player.transform.position;
            hasTarget = true;

            moveDirection = (targetPosition - (Vector2)transform.position).normalized;

            // 시간 지나면 없어짐
            Destroy(gameObject, knife_Delay);
        }
    }

    void Update()
    {
        if (hasTarget)
        {
            transform.position += (Vector3)moveDirection * speed * Time.deltaTime;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 충돌한 객체가 플레이어인 경우
        if (collision.gameObject == player)
        {
            // 플레이어에게 데미지를 입힘
            if (playerHealth != null)
            {
                playerHealth.TakeDamage();
            }

            // 나이프 파괴
            Destroy(gameObject);
        }
    }
}
