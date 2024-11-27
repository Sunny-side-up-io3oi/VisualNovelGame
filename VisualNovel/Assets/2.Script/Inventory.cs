using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<ItemData> items = new List<ItemData>(); // 인벤토리에 저장된 아이템 목록

    public void AddItem(ItemData item)
    {
        if (!items.Contains(item))
        {
            items.Add(item);
            Debug.Log($"{item.itemName}이(가) 인벤토리에 추가되었습니다.");
        }
        else
        {
            Debug.Log($"{item.itemName}은(는) 이미 인벤토리에 있습니다.");
        }
    }

    public void RemoveItem(ItemData item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            Debug.Log($"{item.itemName}이(가) 인벤토리에서 제거되었습니다.");
        }
        else
        {
            Debug.Log($"{item.itemName}은(는) 인벤토리에 없습니다.");
        }
    }
}
