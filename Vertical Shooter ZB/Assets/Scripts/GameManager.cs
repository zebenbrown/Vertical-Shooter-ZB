using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private GameObject[] enemyArray;
    [SerializeField] private List<GameObject> activeEnemyList;

    public string sceneName;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        enemyArray = GameObject.FindGameObjectsWithTag("Enemy");
        //activeEnemyList = new List<GameObject>(enemyArray);
    }

    //public void UnListEnemy(GameObject enemy)
    //{

    //    activeEnemyList.Remove(enemy);
    //    if (activeEnemyList.Count == 0)
    //    {
    //        ResetAllEnemies();
    //        //StartCoroutine(Co_ResetAllEnemiesDelayed(2f));
    //    }
    //}

    private IEnumerator Co_ResetAllEnemiesDelayed(float delay)
    {
        yield return new WaitForSeconds(delay);
        ResetAllEnemies();
    }

    private void ResetAllEnemies()
    {
        foreach (var enemy in enemyArray)
        {
            enemy.GetComponent<Enemy>().RepositionEnemy(false);
            activeEnemyList.Add(enemy);
        }
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
        PlayerPrefs.DeleteKey("HighScore");
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}