using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LobbyScript : MonoBehaviour
{
    public Button gotoBlackJackRomm;
    public Button gotoSlotsromm;
    //public Button gotoCrapsromm;
    //public Button gotoRouletteromm;
    public Button Exit;


    // Start is called before the first frame update
    void Start()
    {
        Button btnBackkjack = gotoBlackJackRomm.GetComponent<Button>();
        btnBackkjack.onClick.AddListener(bjEnter);

        Button btnSlots = gotoSlotsromm.GetComponent<Button>();
        btnSlots.onClick.AddListener(slotEnter);

        Button btnExit = Exit.GetComponent<Button>();
        btnExit.onClick.AddListener(Application.Quit);
    }

    public void bjEnter()
    {
        SceneManager.LoadScene(2);
    }
    public void slotEnter()
    {
        SceneManager.LoadScene(3);
    }


}
