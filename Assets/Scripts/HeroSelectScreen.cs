using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class HeroSelectScreen : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _buyButtonTextMeshProUGUI;
    [SerializeField] private HeroView _heroView;
    [SerializeField] private GameObject _selectButton;
    [SerializeField] private GameObject _buyButton;
    [SerializeField] private HeroStatsVew _heroStatsVew;

    private Action<int> _onHeroSelected;
    private HeroSettings CurrentHero => _heroes[_currentHeroIndex];
    private HeroSettings[] _heroes;
    private int _currentHeroIndex;
   
    private Texture _texture;

    private Wallet _wallet;

    

    public void Show(int currentHeroIndex ,HeroSettings[] heroSettingsArray, Wallet wallet, Action<int > onHeroSelected)
    {
        _onHeroSelected = onHeroSelected;
        _wallet = wallet;
        _heroes = heroSettingsArray;
        ShowHero(currentHeroIndex);
       
    }

    private void ShowHero(int currentHeroIndex)
    {
        _currentHeroIndex = currentHeroIndex;
       
        _heroView.Show(CurrentHero);
        _heroStatsVew.Show(CurrentHero);
        SetStateButton(CurrentHero.IsHeroAvalliable);
        ShowPrice();

    }
    [UsedImplicitly]
    public void SelectHero()
    {
        
         _onHeroSelected?.Invoke(_currentHeroIndex);
       //  _texture = Camera.main.targetTexture;
    }

    private void ShowPrice()
    {
        _buyButtonTextMeshProUGUI.text = CurrentHero.Price.ToString();
            
    }
    [UsedImplicitly]
    public void BuyHero()
    {
        if (_wallet.BuyHero(CurrentHero.Price))
        {
            CurrentHero.MarkAsAvaliable();
            SetStateButton(state:true);
        }
    }
    [UsedImplicitly]
    public void ShowNextHero()
    {
        var currentHeroIndex = (_currentHeroIndex + 1) % _heroes.Length;
        ShowPrice();
        ShowHero(currentHeroIndex);
    }
    [UsedImplicitly]
    public void ShowPreviousHero()
    {
        var currentHeroIndex = (_currentHeroIndex - 1 + _heroes.Length) % _heroes.Length;
        ShowPrice();
        ShowHero(currentHeroIndex);

    }
    private void SetStateButton(bool state)
    {
        _selectButton.SetActive(state);
        _buyButton.SetActive(!state);
    }

    public Texture GetTexture()
    {
        return Camera.main.targetTexture;
    }
}
