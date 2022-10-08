using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class SaveManager
{
    public static void Save(object data)
    {
        string m_jsonString = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.persistentDataPath + "/save.json", m_jsonString);
    }

    public static Data Load<Data>() where Data : new()
    {
        Data data = new Data();

        if (GetIfFileExists())
        {
            string raw = File.ReadAllText(Application.persistentDataPath + "/save.json");
            JsonUtility.FromJsonOverwrite(raw, data);
        }

        return data;
    }

    public static bool GetIfFileExists()
    {
        if (File.Exists(Application.persistentDataPath + "/save.json")) return true;
        return false;
    }
}
