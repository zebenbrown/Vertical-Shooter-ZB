using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour

{

  public int maxHealth = 10;
        public int currentHealth;
    public TextMeshProUGUI HealthText;

    [SerializeField] private string sceneName;

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    

    private void Start()
    {
        currentHealth = maxHealth;
    }

    /*public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        HealthText.text = "Health: " + currentHealth.ToString();

        if (currentHealth <= 0)
        {
            LoadScene();
        }

    }*/
        
    private void Update()
    {
        HealthText.text = "Health: " + currentHealth.ToString();

    }

   


}