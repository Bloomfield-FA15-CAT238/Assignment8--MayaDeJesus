using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayAgain : MonoBehaviour
{

    // Update is called once per frame
    public void changeScene(int changeScene)
    {
        Application.LoadLevel("menupos");
    }
}