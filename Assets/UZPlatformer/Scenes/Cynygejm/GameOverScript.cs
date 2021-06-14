using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class GameOverScript : MonoBehaviour
{

    public ScoreManager ScoreManager;
    public float pointsText;
    public void RestartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitButton()
    {
        SceneManager.LoadScene(0);
    }

}
