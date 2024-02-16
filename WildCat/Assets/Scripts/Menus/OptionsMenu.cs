using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    [Header("Options Menu")]
    [SerializeField] private Button newGame;
    [SerializeField] private Button continueGame;

    private void Start()
    {
        //if (!DataPersistenceManager.instance.HasGameData())
        //{
        //    continueGame.interactable = false;
        //}
    }


    public void OnNewGameClicked()
    {
        DisableOptionButtons();
        //DataPersistenceManager.instance.NewGame();
        SceneManager.LoadSceneAsync("Level1");
    }
    public void OnContinueGameClicked()
    {
        DisableOptionButtons();
        SceneManager.LoadSceneAsync("Level1");
    }
    private void DisableOptionButtons()
    {
        newGame.interactable = false;
        continueGame.interactable = false;
    }
}
