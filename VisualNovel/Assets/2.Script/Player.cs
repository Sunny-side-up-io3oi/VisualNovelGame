using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f; // 캐릭터 이동 속도
    private Rigidbody2D rigid;
    private float h;
    private float v;
    private bool isHorizonMove;
    private Animator animator;
    //public SpriteRenderer playerRender; // 캐릭터 SpriteRenderer 컴포넌트를 연결합니다.
    public float magnituteThreshold = 0.1f; // 움직임 감지 임계값
    private static readonly string isWalking = "isWalk"; // Animator 파라미터 이름

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>(); // Animator 초기화
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

        // Move 메서드 호출
        Move(moveVec);
    }

    private void Move(Vector2 vector)
    {
        // 움직임에 따라 애니메이션 상태 변경
        animator.SetBool(isWalking, vector.magnitude > magnituteThreshold);

        // 방향 설정
        if (vector.magnitude > 0)
        {
            animator.SetFloat("xDir", vector.x);
            animator.SetFloat("yDir", vector.y);
        }
    }
}
