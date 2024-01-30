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

    [SerializeField] private string sceneName;

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }



    private void Start()
    {
        startingHealth = 30;
    }

    public void TakeDamage(int amount)
    {
       startingHealth -= amount;
        

        HealthText.text = "Health: " + startingHealth.ToString();

        if (startingHealth <= 0)
        {
            LoadScene();
        }
    }
        
    private void Update()
    {
        HealthText.text = "Health: " + startingHealth.ToString();

    }

   


}