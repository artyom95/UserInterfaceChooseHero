using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using Slider = UnityEngine.UI.Slider;

public class HeroStatsVew : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _heroName;
    
    [SerializeField] private Slider _health;
    [SerializeField] private Slider _speed;
    [SerializeField] private Slider _defense;
    [SerializeField] private Slider _attack;
    
    public void Show(HeroSettings hero)
    {
        _heroName.text = hero.Name;
        _health.value = hero.Health;
        _speed.value = hero.Speed;
        _defense.value = hero.Defense;
        _attack.value = hero.Attack;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
