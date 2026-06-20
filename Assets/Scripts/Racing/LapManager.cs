using UnityEngine;

public class LapManager : MonoBehaviour
{
    public int CurrentLap = 1;
    public int MaxLaps = 3;

    public void CompleteLap()
    {
        CurrentLap++;

        if(CurrentLap > MaxLaps)
        {
            Debug.Log("Race Finished");
        }
    }
}
