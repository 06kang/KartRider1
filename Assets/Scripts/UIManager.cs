using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject Menu, Quit, X, Xbutton, penel;
    public bool isClick = false;
    public GameObject panelLobby, panelSelect,startbtn;

    public void ShowSelectMap()
    {
        startbtn.SetActive(false);
        panelSelect.SetActive(true);
    }
    public void HidePanelSelect() {
        startbtn.SetActive(true);
        panelLobby.SetActive(true);
        panelSelect.SetActive(false);    
    }
    public void HideSelectMap()
    {
        panelSelect.SetActive(false);
    }

    public void StartMap(int mapId)
    {
        SceneManager.LoadScene(mapId);
    }


    public void OnClick()
    {

        Menu.SetActive(true);
        Quit.SetActive(true);
        Xbutton.SetActive(true);
        penel.SetActive(true);
        X.SetActive(false);
    }

    public void GoMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void Exit()
    {
        X.SetActive(true);
        Menu.SetActive(false);
        Quit.SetActive(false);
        Xbutton.SetActive(false);
        penel.SetActive(false);
    }
}
