using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int hintKeys = 0; // 초기 힌트 열쇠 수

    // 힌트 열쇠를 추가하는 메서드
    public void AddHintKey()
    {
        hintKeys++;
        Debug.Log("Hint key added. Total keys: " + hintKeys);
    }
}
