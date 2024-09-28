using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour
{
    public int hintKeys = 0; // 플레이어가 가지고 있는 힌트 키 개수
    public int hintKeyPrice = 1; // 힌트 키 가격
    public TMP_Text hintKeyText; // 힌트 키 개수를 보여줄 TextMeshProUGUI

    void Start()
    {
        UpdateHintKeyText(); // 시작 시 텍스트 업데이트
    }

    // 힌트 키를 구매하는 메서드
    public void BuyHintKey()
    {
        // 플레이어가 금액 없이 바로 구매 가능
        hintKeys += 1;
        UpdateHintKeyText(); // 텍스트 업데이트
    }

    // 힌트 키 개수 텍스트 업데이트
    void UpdateHintKeyText()
    {
        hintKeyText.text = hintKeys.ToString(); // TextMeshPro 텍스트 갱신
    }
}
