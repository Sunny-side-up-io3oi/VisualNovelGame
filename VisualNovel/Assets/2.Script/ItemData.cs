using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "ScriptableObjects/ItemData", order = 1)]
public class ItemData : ScriptableObject
{
    public string itemName; // 아이템 이름
    public Sprite itemIcon; // 아이템 아이콘
    public float itemScore; // 아이템 점수
    public string itemInform; // 아이템 설명
}
