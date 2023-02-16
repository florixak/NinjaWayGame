using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveSystem : MonoBehaviour
{
    public Data data;

    private void Awake()
    {
        LoadGame();
    }

    public void LoadGame()
    {
        FileStream fs = new FileStream(Application.persistentDataPath + "/SaveGame.sav", FileMode.Open);
        BinaryFormatter bf = new BinaryFormatter();

        try
        {
            data = (Data) bf.Deserialize(fs);
        }
        catch
        {
            Debug.Log("Failed to load!");
        }
        finally { fs.Close(); }
    }

    public void SaveGame()
    {
        FileStream fs = new FileStream(Application.persistentDataPath + "/SaveGame.sav", FileMode.Create);
        BinaryFormatter bf = new BinaryFormatter();
        try
        {
            bf.Serialize(fs, data);
        } 
        catch
        {
            Debug.Log("Failed to serialize!");
        }
        finally { fs.Close(); }
    }

    private void OnDestroy()
    {
        SaveGame();
    }

}
