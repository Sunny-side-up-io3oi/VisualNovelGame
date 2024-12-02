using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public Inventory inventory; // 인벤토리 참조
    public Transform itemListParent; // 아이템 리스트가 배치될 부모 오브젝트
    public GameObject itemButtonPrefab; // 아이템 버튼 프리팹
    public Text progressText; // 진행도 텍스트

    private int totalItems = 50; // 전체 아이템 수

    void Start()
    {
        UpdateInventoryUI();
    }

    public void UpdateInventoryUI()
    {
        // 기존 UI 제거
        foreach (Transform child in itemListParent)
        {
            Destroy(child.gameObject);
        }

        // 아이템 리스트 UI 생성
        foreach (var item in inventory.items)
        {
            GameObject newItemButton = Instantiate(itemButtonPrefab, itemListParent);
            newItemButton.GetComponentInChildren<Text>().text = item.itemName;
            newItemButton.GetComponent<Image>().sprite = item.itemIcon;
        }

        // 진행도 업데이트
        UpdateProgress();
    }

    public void UpdateProgress()
    {
        int foundItems = inventory.items.Count;
        progressText.text = $"진행도: {foundItems} / {totalItems}";

        if (foundItems >= totalItems)
        {
            progressText.text += " - 모든 아이템을 찾았습니다!";
        }
    }
}
