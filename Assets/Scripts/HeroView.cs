using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroView : MonoBehaviour
{
   [SerializeField] private Transform _heroRoot;

   public  void Show(HeroSettings heroSettings)
   {
      foreach (Transform child in _heroRoot)
      {
         Destroy(child.gameObject);
      }
      var hero = Instantiate(heroSettings.PrefabHero, _heroRoot);
   }
}
