using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class Wallet : MonoBehaviour
{
     [SerializeField] private TextMeshProUGUI _amountMoneyLobbyMainScreen;
     [SerializeField] private TextMeshProUGUI _amountMoneyHeroesSelectScreen;
     [SerializeField] private ScreenController _screenController;
     private float _money = 9999999f;
    
    
    // Start is called before the first frame update
   
   private void Update()
   {
       SetMoney();
   }

   private void SetMoney()
   {
       if (_screenController.GetStateMainScreen())
       {
           _amountMoneyLobbyMainScreen.text = _money.ToString();

       }
       else
       {
           _amountMoneyHeroesSelectScreen.text = _money.ToString();

       }
           
    }

   public bool BuyHero(float cost)
   {
       if (_money > cost)
       {
           _money -= cost;
           SetMoney();
           return true;
       }
       else
       {
           return false;
       }
   }
    
}
