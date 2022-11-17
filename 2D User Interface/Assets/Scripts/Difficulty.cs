using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Difficulty : MonoBehaviour
{
    public int DifficultyAmmount;
    private Button _button;
    private GameManager _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _button = GetComponent<Button>();
        _button.onClick.AddListener(SetDifficulty);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    private void SetDifficulty()
    {
        //Debug.Log(gameObject.name + " was clicked");
        _gameManager.StartGame(DifficultyAmmount);
    }
}
