using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (Input.GetKeyDown("space")) {
            //Vector3 v = new Vector3(0, 0.5f, 0);
            Instantiate(bullet, transform.position + Vector3.up*(0.5f) +Vector3.forward , transform.rotation);
        }

        if ((playerFood == 3) && (playerScore == 3)) {
            SceneManager.LoadScene(2);
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "figurine")
        {
            playerScore += 1;
            Destroy(other.gameObject);
        }
    }

    public void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 50), "Immunity figurines: " + playerScore);
        GUI.Label(new Rect(10, 30, 200, 50), "Player Lives: " + playerFood);
    }
}
