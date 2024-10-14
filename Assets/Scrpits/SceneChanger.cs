using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SceneChanger : MonoBehaviour
{
    
    public TMP_InputField idInputField;
    private string playerId;


    public void StartButton()
    {
        playerId = idInputField.text;

        if (playerId.Length >= 2 && playerId.Length <= 10)
        {
            PlayerPrefs.SetString("PlayerID", playerId);
            SceneManager.LoadScene("MainScene");
        }
        
 
        else
        {
            SceneManager.LoadScene("StartScene");

        }
    }

}
