using UnityEngine;
using Yarn.Unity;

public class YarnDialogueHandler : MonoBehaviour
{
    public DialogueRunner dialogueRunner;
    private static bool hasDialoguePlayed = false; // 대화 실행 여부를 저장하는 플래그

    void Start()
    {
        // 대화가 이전에 실행되지 않았다면 실행
        if (!hasDialoguePlayed)
        {
            dialogueRunner.StartDialogue("CrimeScene"); // "Start"를 원하는 노드 이름으로 변경
            hasDialoguePlayed = true; // 대화가 실행되었음을 표시
        }
    }
}
