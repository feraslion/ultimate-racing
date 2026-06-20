using UnityEngine;

public static class SaveManager
{
    public static void Save()
    {
        PlayerPrefs.SetInt("Coins", GameManager.Instance.Coins);
        PlayerPrefs.Save();
    }

    public static void Load()
    {
        GameManager.Instance.Coins =
            PlayerPrefs.GetInt("Coins", 5000);
    }
}
