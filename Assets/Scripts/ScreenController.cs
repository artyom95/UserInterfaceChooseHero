using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Serialization;

public class ScreenController : MonoBehaviour
{
    [SerializeField] 
    private GameObject _lobbyMainScreen;

     [SerializeField]
    private GameObject _heroesScreen;

    private bool _isLobbyMainScreenAvaliable;
    [UsedImplicitly]
    public void TurnOnLobbyMainScreen()
    {
        _lobbyMainScreen.SetActive(true);
        _heroesScreen. SetActive(false);
        _isLobbyMainScreenAvaliable = true;
    }
    [UsedImplicitly]
    public void TurnOnHeroesScreen()
    {
        _lobbyMainScreen.SetActive(false);
        _heroesScreen. SetActive(true);
        _isLobbyMainScreenAvaliable = false;
    }

    public bool GetStateMainScreen()
    {
        return _isLobbyMainScreenAvaliable;
    }
}
