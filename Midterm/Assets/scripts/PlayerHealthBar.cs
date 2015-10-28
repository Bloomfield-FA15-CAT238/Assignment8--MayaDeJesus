using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealthBar : MonoBehaviour
{

    public GameObject player;
    public GameController GameController;
    public Slider healthbar;
    public int playerHealth = 100;
    public int currentHealth;

    void Start()
    {
        currentHealth = playerHealth;
        healthbar.maxValue = playerHealth;
        healthbar.value = playerHealth;
    }

    //Upon taking damage, what causes the damage will call this method.
    public void takeDamage()
    {
        //If this method is called, the player takes 10 damage.
        currentHealth -= 5;

        //The Health Slider should set to the current health value.
        healthbar.value = currentHealth;

        //If health reaches 0 or lower, the player respawns and the Start function runs again to reset health.
        if (currentHealth <= 0)
        {
            GameController.RespawnPlayer();
            Start();
        }
    }
}