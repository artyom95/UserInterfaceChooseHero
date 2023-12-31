using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class LobbyController : MonoBehaviour
{
   [SerializeField] private ScreenController _screenController;
   [SerializeField] private GameSettings _gameSettings;
   [SerializeField] private Wallet _wallet;
   [SerializeField] private LobbyMainScreen _lobbyMainScreen;
   [SerializeField] private HeroSelectScreen _heroSelectScreen;

   private int _currentHeroIndex = 0;
   private int _selectHeroIndex = 0;

  private void Awake()
  {
    _screenController.TurnOnLobbyMainScreen();
    ShowLobbyScreen();

  }

  public void ShowLobbyScreen()
  {
      _lobbyMainScreen.Show(_selectHeroIndex, _gameSettings.HeroStSettingsArray);
  }

   [UsedImplicitly]
   public void ShowSelectScreen()
   {
      _heroSelectScreen.Show(_selectHeroIndex,_gameSettings.HeroStSettingsArray, _wallet, OnHeroSelected);
   }

   private void OnHeroSelected(int heroIndex)
   {
       _selectHeroIndex = _heroSelectScreen.GetSelectHeroIndex();
       _currentHeroIndex = heroIndex;
   }

   private void Update()
   {
      

       
   }
}
