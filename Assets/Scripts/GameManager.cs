using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int gold;
    public TextMeshProUGUI goldText;
    public Sprite[] backgrounds;
    private int currentBackground;
    private int enemiesUnitilBackgroundChange;
    public Image backgroundImage;

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
        enemiesUnitilBackgroundChange = 5;
    }

    public void AddGold (int amount)
    {
        gold += amount;
        goldText.text = "Gold: " + gold.ToString();
    }

    public void TakeGold(int amount)
    {
        gold -= amount;
        goldText.text = "Gold: " + gold.ToString();
    }

    public void BackgroundCheck()
    {
        enemiesUnitilBackgroundChange--;

        if(enemiesUnitilBackgroundChange == 0)
        {
            enemiesUnitilBackgroundChange = 5;

            currentBackground++;

            if (currentBackground == backgrounds.Length)
                currentBackground = 0;

            backgroundImage.sprite = backgrounds[currentBackground];
        }
    }
}
