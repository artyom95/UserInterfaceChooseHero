using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyMainScreen : MonoBehaviour
{
    [SerializeField] 
    private HeroView _heroView;
     public void Show(int heroIndex, HeroSettings[] heroes)
    {
        _heroView.Show(heroes[heroIndex]);
    }
    
    // Start is called before the first frame update
   /* private void Update()
    {
        Camera.main.targetTexture = (RenderTexture)_heroSelectScreen.GetTexture();
    }
*/
    // Update is called once per frame
   
}
