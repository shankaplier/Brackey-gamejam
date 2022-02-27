using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtScript : MonoBehaviour
{
    public string SeedPlanted;
    public string DirtState;
    public GameObject Planttogrow;
    public GameObject Daisy;
    public GameObject Lavender;
    public GameObject Rose;
    public GameObject Tulip;
    public int noofPlants;

    private void Awake()
    {
        SeedPlanted = "None";
        DirtState = "Plain";
        noofPlants = 0;
    }

    private void Update()
    {
        if (SeedPlanted == "Daisy") 
        {
            Planttogrow = Daisy;
        }
        else if (SeedPlanted == "Lavender")
        {
            Planttogrow = Lavender;
        }
        else if (SeedPlanted == "Rose")
        {
            Planttogrow = Rose;
        }
        else if (SeedPlanted == "Tulip")
        {
            Planttogrow = Tulip;
        }

    }
}
