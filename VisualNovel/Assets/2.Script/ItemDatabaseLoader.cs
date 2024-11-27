using UnityEngine;

[CreateAssetMenu(fileName = "ItemDatabaseLoader", menuName = "ScriptableObjects/ItemDatabaseLoader", order = 3)]
public class ItemDatabaseLoader : MonoBehaviour
{
    public ItemDatabase itemDatabase;

    void Start()
    {
        LoadAllItems();
    }

    void LoadAllItems()
    {
        ItemData[] items = Resources.LoadAll<ItemData>("Items");

        foreach (var item in items)
        {
            if (!itemDatabase.allItems.Contains(item))
            {
                itemDatabase.allItems.Add(item);
            }
        }

        Debug.Log($"{itemDatabase.allItems.Count}개의 아이템이 데이터베이스에 로드되었습니다.");
    }
}
