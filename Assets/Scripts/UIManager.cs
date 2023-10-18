using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
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
}
