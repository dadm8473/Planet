using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public void ReStart_Button()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit_Button()
    {
        SceneManager.LoadScene(0);

    }
}
