using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour

{

  //public int maxHealth = 30;
    public int startingHealth;
    public TextMeshProUGUI HealthText;
    public int amount;

    [SerializeField] private string sceneName;

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }



    private void Start()
    {
        startingHealth = 30;
    }

    public bool TakeDamage(int amount)
    {
       startingHealth -= amount;
        

        HealthText.text = "Health: " + startingHealth.ToString();

        if (startingHealth <= 0)
        {
            LoadScene();
        }
        return true;
    }
        
    private void Update()
    {
        HealthText.text = "Health: " + startingHealth.ToString();
        if (TakeDamage(amount) == true)
        {
            TakeDamage(amount);
        }

    }

   


}