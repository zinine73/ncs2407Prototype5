using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private Button button;
    private GameManager gm;

    public int difficulty;

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        button = GetComponent<Button>();    
        button.onClick.AddListener(SetDifficulty);
    }

    private void SetDifficulty()
    {
        Debug.Log(gameObject.name + " was clicked");
        gm.StartGame(difficulty);
    }
}
