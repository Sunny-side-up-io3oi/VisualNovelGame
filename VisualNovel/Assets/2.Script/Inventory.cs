using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<ItemData> items = new List<ItemData>(); // 인벤토리에 저장된 아이템 목록
    public InventoryUI inventoryUI; // UI와 연결

    public void AddItem(ItemData item)
    {
        if (!items.Contains(item))
        {
            items.Add(item);
            Debug.Log($"{item.itemName}이(가) 인벤토리에 추가되었습니다.");
            inventoryUI.UpdateInventoryUI(); // UI 업데이트
        }
        else
        {
            Debug.Log($"{item.itemName}은(는) 이미 인벤토리에 있습니다.");
        }
    }
}
