using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Data
{
    private static bool initialized;

    public static bool GetInitialized()
    {
        return initialized;
    }

    private static GameData gameData;

    public static GameData GetGameData() //this should be called GetGameData
    {
        return gameData;
    }

    public static void Save()
    {
        SaveManager.Save(gameData);
    }

    public static void Load()
    {
        if (initialized) return;

        gameData = SaveManager.Load<GameData>();

        initialized = true;
    }
}
