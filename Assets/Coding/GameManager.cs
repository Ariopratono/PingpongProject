using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Variabel untuk Score")]
    public int PlayerScoreL;
    public int PlayerScoreR;

    [Header("Text untuk Score")]
    public TMP_Text txtPlayerScoreL;
    public TMP_Text txtPlayerScoreR;

    [Header("Panel Player Win")]
    public GameObject panelWin;
    public TMP_Text playerWin;

    public static GameManager instance;
    public LoadScene sm;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        panelWin.SetActive(false);
    }

    public void Score(string wallID) 
    {
        if (wallID == "Garis_Kiri")
        {
            //Debug.Log("kena Line L nih");
            PlayerScoreR = PlayerScoreR + 10;
            txtPlayerScoreR.text = PlayerScoreR.ToString();
            ScoreCheck();
        }
        else
        {
            //Debug.Log("kena line R woi");
            PlayerScoreL = PlayerScoreL + 10;
            txtPlayerScoreL.text = PlayerScoreL.ToString();
            ScoreCheck();
        }
    }

    public void ScoreCheck()
    {
        if (PlayerScoreL == 20)
        {
            panelWin.SetActive(true);
            playerWin.text = "Player L Win!!";
            Debug.Log("Kepanggil 0");
            Invoke("ChangeTheScene", 2f);
        }
        else if (PlayerScoreR == 20)
        {
            panelWin.SetActive(true);
            playerWin.text = "Player R Win!!";
            Debug.Log("Kepanggil 0");
            Invoke("ChangeTheScene", 2f);   
        }
    }

    public void ChangeTheScene()
    {
        Debug.Log("Kepanggil 1");
        //this.gameObject.SendMessage("ChangeTheScene", "Main Menu");
        sm.ChangeScene("Menu");
    }
}
