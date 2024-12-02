using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public Inventory inventory; // 인벤토리 참조

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
            ItemObject itemObject = collision.GetComponent<ItemObject>();

            if (itemObject != null)
            {
                inventory.AddItem(itemObject.itemData);
                Destroy(collision.gameObject); // 아이템 오브젝트 제거
            }
        }
    }
}
