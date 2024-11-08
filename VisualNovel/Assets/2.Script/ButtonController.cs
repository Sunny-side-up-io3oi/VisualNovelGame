using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class ButtonController : MonoBehaviour
{
    public GameObject myButtonObject; // 버튼의 GameObject를 연결합니다.

    // Yarn Spinner의 DialogueRunner를 참조합니다.
    public DialogueRunner dialogueRunner;

    void Start()
    {
        // 초기 상태: 버튼 비활성화 (안 보이게)
        myButtonObject.SetActive(false);

        // Yarn Spinner 이벤트 등록
        dialogueRunner.onDialogueComplete.AddListener(ShowButton);
    }

    void ShowButton()
    {
        // 대화가 끝나면 버튼 보이게 활성화
        myButtonObject.SetActive(true);
    }
}
