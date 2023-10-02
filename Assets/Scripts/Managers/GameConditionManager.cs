using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameConditionManager
{
    public UnityAction<bool> GameEnded;

    public GameConditionManager()
    {
        GameEnded += DebugEndGame;
    }
    public void EndGame(bool condition) => GameEnded?.Invoke(condition);

    private void DebugEndGame(bool i)
    {
        Debug.Log(i+ " game");
    }
    
}
