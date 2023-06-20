using System;
using UnityEngine;


[Serializable]
public class HeroSettings
{
    [field:SerializeField]
   public string Name {get ; private  set; }
   
   [field:SerializeField]
   public int Health {get ; private  set; }
   
   [field:SerializeField]
   public int Attack {get ; private  set; }
   
   [field:SerializeField]
   public int Defense {get ; private  set; }
   
   [field:SerializeField]
   public int Speed {get ; private  set; }
   
   [field:SerializeField]
   public float Price {get ; private  set; }
   
   [field:SerializeField]
   public GameObject PrefabHero {get ; private  set; }
   [field:SerializeField]
   public bool IsHeroAvalliable { get; private set; }

   public void MarkAsAvaliable()
   {
       IsHeroAvalliable = true;
   }
}
