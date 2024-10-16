using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int hintKeys;
    public int progress;

    public TextMeshProUGUI hintKeysText; 
    public string saveFilePath;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            LoadGame();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        UpdateHintKeysText(); 
    }

    public void AddHintKey()
    {
        hintKeys++;
        SaveGame();
    }

    public void SaveGame()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(saveFilePath, FileMode.Create);

        GameData data = new GameData
        {
            hintKeys = hintKeys,
            progress = progress
        };

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public void LoadGame()
    {
        if (File.Exists(saveFilePath))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(saveFilePath, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();

            hintKeys = data.hintKeys;
            progress = data.progress;
        }
    }

    private void UpdateHintKeysText()
    {
        hintKeysText.text = "��ƮŰ: " + hintKeys.ToString();
    }
}

[System.Serializable]
public class GameData
{
    public int hintKeys;
    public int progress;
}
