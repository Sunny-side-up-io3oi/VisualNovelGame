using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameSaveManager : MonoBehaviour
{
    [System.Serializable]
    public class SaveData
    {
        public List<string> inventoryItemIDs; // 인벤토리 아이템 ID 목록
        public int currentLevel; // 현재 레벨
        public float playTime; // 플레이 시간

        public SaveData(List<string> itemIDs, int level, float time)
        {
            inventoryItemIDs = itemIDs;
            currentLevel = level;
            playTime = time;
        }
    }

    public List<ItemData> inventory = new List<ItemData>(); // 인벤토리에 저장된 아이템 목록
    public int currentLevel; // 플레이어의 현재 레벨
    public float playTime; // 플레이 시간
    private string saveFilePath;

    void Start()
    {
        saveFilePath = Path.Combine(Application.persistentDataPath, "saveData.json");
    }

    // 저장 기능
    public void SaveGame()
    {
        // 인벤토리 아이템 ID 저장
        List<string> itemIDs = new List<string>();
        foreach (var item in inventory)
        {
            itemIDs.Add(item.name); // ScriptableObject의 이름 사용
        }

        // SaveData 생성
        SaveData saveData = new SaveData(itemIDs, currentLevel, playTime);

        // JSON 저장
        string json = JsonUtility.ToJson(saveData, true);
        File.WriteAllText(saveFilePath, json);

        Debug.Log($"게임 저장 완료: {saveFilePath}");
    }

    // 불러오기 기능
    public void LoadGame()
    {
        if (File.Exists(saveFilePath))
        {
            string json = File.ReadAllText(saveFilePath);
            SaveData saveData = JsonUtility.FromJson<SaveData>(json);

            // 인벤토리 복원
            inventory.Clear();
            foreach (var id in saveData.inventoryItemIDs)
            {
                ItemData item = Resources.Load<ItemData>("Items/" + id);
                if (item != null)
                {
                    inventory.Add(item);
                }
            }

            // 진행도 복원
            currentLevel = saveData.currentLevel;
            playTime = saveData.playTime;

            Debug.Log($"게임 로드 완료: {saveFilePath}");
        }
        else
        {
            Debug.LogWarning("저장된 데이터가 없습니다.");
        }
    }

    // 진행도 업데이트 (예: UI 업데이트 시 활용)
    public void UpdateProgress()
    {
        Debug.Log($"현재 레벨: {currentLevel}, 플레이 시간: {playTime}, 발견한 아이템 수: {inventory.Count}");
    }
}
