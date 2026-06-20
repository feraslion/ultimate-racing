using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int Coins;
    public int Gems;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddCoins(int amount)
    {
        Coins += amount;
        SaveManager.Save();
    }

    public bool SpendCoins(int amount)
    {
        if (Coins < amount)
            return false;

        Coins -= amount;
        SaveManager.Save();
        return true;
    }
}
