using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f; // 캐릭터 이동 속도
    private Rigidbody2D rigid;
    private float h;
    private float v;
    private bool isHorizonMove;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 입력 처리
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        // 방향키 입력에 따른 상태 변경
        bool hDown = Input.GetButtonDown("Horizontal");
        bool vDown = Input.GetButtonDown("Vertical");
        bool hUp = Input.GetButtonUp("Horizontal");
        bool vUp = Input.GetButtonUp("Vertical");

        if (hDown)
        {
            isHorizonMove = true;
        }
        else if (vDown)
        {
            isHorizonMove = false;
        }
        else if (hUp || vUp)
        {
            isHorizonMove = h != 0;
        }
    }

    void FixedUpdate()
    {
        // 이동 벡터 계산
        Vector2 moveVec = isHorizonMove ? new Vector2(h, 0) : new Vector2(0, v);
        // 캐릭터 이동
        rigid.MovePosition(rigid.position + moveVec * moveSpeed * Time.fixedDeltaTime);
    }
}
