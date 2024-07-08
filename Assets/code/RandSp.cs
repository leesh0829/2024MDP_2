using System.Collections;
using UnityEngine;

// 랜덤 스폰 관리
public class RandSp : MonoBehaviour
{
    // 소환할 오브젝트
    public GameObject rangeObject;
    // 소환할 장소
    BoxCollider2D rangeCollider;
    // 소환할 시간
    public float  delay = 3f;

    private void Awake()
    {
        rangeCollider = rangeObject.GetComponent<BoxCollider2D>();
        if (rangeCollider == null)
        {
            Debug.LogError("비어있음");
        }
    }

    Vector3 Return_RandomPosition()
    {
        Vector3 originPosition = rangeObject.transform.position;
        // 콜라이더의 사이즈를 가져오는 bound.size 사용
        float range_X = rangeCollider.bounds.size.x;
        float range_Y = rangeCollider.bounds.size.y;

        float randomX = Random.Range((range_X / 2) * -1, range_X / 2);
        float randomY = Random.Range((range_Y / 2) * -1, range_Y / 2);
        Vector3 randomPosition = new Vector3(randomX, randomY, 0f);

        Vector3 respawnPosition = originPosition + randomPosition;
        return respawnPosition;
    }

    // 소환할 Object
    public GameObject weapon;
    private void Start()
    {
        // 1초마다 한번 실행
        StartCoroutine(RandomRespawn_Coroutine());
    }

    IEnumerator RandomRespawn_Coroutine()
    {
        // while식 바꾸기
        while (true)
        {
            yield return new WaitForSeconds(delay);

            // 생성 위치 부분에 위에서 만든 함수 Return_RandomPosition() 함수 대입
            Instantiate(weapon, Return_RandomPosition(), Quaternion.identity);
        }
    }
}
