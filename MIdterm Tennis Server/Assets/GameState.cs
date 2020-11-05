using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameState : MonoBehaviour
{
    [SerializeField] GameObject _instructions;
    [SerializeField] GameObject _return;
    [SerializeField] GameObject _scoreText;
    [SerializeField] GameObject _powerText;
    [SerializeField] GameObject _gameOverText;
    int _score = 0;
    int _enemyScore = 0;
    public static GameState Instance;
    public bool End = false;
    
    
    void Awake() {
        Instance = this;
    }
    void Update() 
    {
        if(_enemyScore >= 5 && (_enemyScore - _score) > 1){
            GameOverLoss();
        }
        if(_score >= 5 && (_score - _enemyScore)>1){
            GameOverWin();
        }
        if(Input.GetButtonDown("Submit")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            _return.SetActive(false);
        }
        if(Input.GetKeyDown("space")){
            _instructions.SetActive(false);
        }

        
        
    }

    public void IncreaseScore(int ammount)
    {
        _score += ammount;
        _scoreText.GetComponent<Text>().text = "Score: "+ _score + " | "+_enemyScore;

    }
    public void IncreaseEnemyScore(int ammount)
    {
        _enemyScore += ammount;
        _scoreText.GetComponent<Text>().text = "Score: "+ _score + " | "+_enemyScore;
    }
   public void DisplayPower(float power)
   {
       _powerText.GetComponent<Text>().text = "Power: "+ power;
   }
   public void GameOverWin()
   {
       _gameOverText.SetActive(true);
       _gameOverText.GetComponent<Text>().text = "Victory!";
       End = true;
       _return.SetActive(true);
       _powerText.SetActive(false);

   }
   public void GameOverLoss()
   {
        _gameOverText.SetActive(true);
        _gameOverText.GetComponent<Text>().text = "You Lose :(";
        End = true;
        _return.SetActive(true);
        _powerText.SetActive(false);
        
   }
}
