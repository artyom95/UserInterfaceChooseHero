using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] 
    private RawImage _rawImage;

    [SerializeField]
    private Transform _transformPositionGameObject;

    [SerializeField] 
    private Texture _texture;


    // Start is called before the first frame update
   //void Awake()
   //{
   // _rawImage.texture = _texture;
   
   //    _rawImage.transform.position = _transformPositionGameObject.position;
   //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
