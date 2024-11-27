using UnityEngine;
using UnityEditor;

public class ItemCreator : MonoBehaviour
{
    [MenuItem("Tools/Create Items")]
    public static void CreateItems()
    {
        string path = "Assets/Resources/Items/";
        if (!AssetDatabase.IsValidFolder(path))
        {
            AssetDatabase.CreateFolder("Assets/Resources", "Items");
        }

        for (int i = 1; i <= 50; i++)
        {
            ItemData newItem = ScriptableObject.CreateInstance<ItemData>();
            newItem.itemName = "Item " + i;
            newItem.itemInform = "Description for Item " + i;
            //newItem.itemScore = Random.Range(1f, 100f); // 랜덤 점수 생성
            //newItem.rarity = Random.Range(1, 4); // 희귀도 랜덤 설정

            AssetDatabase.CreateAsset(newItem, path + "Item_" + i + ".asset");
        }

        AssetDatabase.SaveAssets();
        Debug.Log("아이템이 생성되었습니다!");
    }
}
