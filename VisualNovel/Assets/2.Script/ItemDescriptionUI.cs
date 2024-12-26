using UnityEngine;
using UnityEngine.UI;

public class ItemDescriptionUI : MonoBehaviour
{
    public GameObject descriptionPanel; // 아이템 상세 정보 패널
    public Text itemNameText; // 아이템 이름 텍스트
    public Image itemIconImage; // 아이템 아이콘 이미지
    public Text itemScoreText; // 아이템 점수 텍스트
    public Text itemInformText; // 아이템 설명 텍스트

    void Start()
    {
        HideDescription(); // 초기 상태에서 숨김
    }

    public void ShowDescription(ItemData itemData)
    {
        descriptionPanel.SetActive(true);
        itemNameText.text = itemData.itemName;
        itemIconImage.sprite = itemData.itemIcon;
        itemScoreText.text = $"Score: {itemData.itemScore}";
        itemInformText.text = itemData.itemInform; // 수정된 부분
    }

    public void HideDescription()
    {
        descriptionPanel.SetActive(false);
    }
}
