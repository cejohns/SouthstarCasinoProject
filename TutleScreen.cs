using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutleScreen : MonoBehaviour
{

    public Button StartGame;
    public Button Exit;
    

    // Start is called before the first frame update
    void Start()
    {
        Button btnStart = StartGame.GetComponent<Button>();
        btnStart.onClick.AddListener(GameStart);

        Button btnExit = Exit.GetComponent<Button>();
        btnExit.onClick.AddListener(Application.Quit);
    }

    public void GameStart()
    {
        SceneManager.LoadScene(1);
    }
}
