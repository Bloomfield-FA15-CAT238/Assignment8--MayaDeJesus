using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class managerChangeScene : MonoBehaviour {

    public void changeScene(string changeScene)
    {

        Application.LoadLevel("Midterm");
    }
}
