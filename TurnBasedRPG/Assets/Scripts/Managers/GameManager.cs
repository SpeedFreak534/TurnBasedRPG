using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Character[] playerTeam;
    public Character[] enemyTeam;

    private List<Character> allCharacters = new List<Character>();

    [Header("Components")]
    public Transform[] playerTeamSpawns;
    public Transform[] enemyTeamSpawns;

    [Header("Data")]
    public PlayerPersistentData playerPersistentData;
    public CharacterSet defaultEnemySet;

    public static GameManager instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
}
