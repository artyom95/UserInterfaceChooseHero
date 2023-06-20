using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour
{
    [field: SerializeField]
    public HeroSettings[]  HeroStSettingsArray { get; private set; }
   
}
