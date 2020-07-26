using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScoreScript : MonoBehaviour
{
    public static int playerScore;
    public static int playerFood;
    public GameObject bullet;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 50), "Immunity figurines: " + playerScore);
        GUI.Label(new Rect(10, 10, 200, 50), "/nPlayer Lives: " + playerFood);
    }
}
