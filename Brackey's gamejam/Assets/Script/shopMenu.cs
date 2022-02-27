using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopMenu : MonoBehaviour
{
    //variables to keep track of how many of each Item have been sold
    public float tulips;
    public float daisies;
    public float roses;
    public float lavender;

    public static bool GameIsPaused = false;

    public GameObject shopMenuUI;
    private void Awake()
    {
        shopMenuUI.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Resume();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
    }

    void Resume()
    {
        shopMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        shopMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void SellRoses()
    {
        roses++;
    }

    public void SellLavender()
    {
        lavender++;
    }

    public void SellDaisies()
    {
        daisies++;
    }

    public void SellTulips()
    {
        tulips++;
    }
}
