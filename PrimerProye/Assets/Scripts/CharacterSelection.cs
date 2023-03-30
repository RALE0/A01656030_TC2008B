using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{
    public int skinNumber;
    public Skins[] skins;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        if (skinNumber > skins.Length - 1)
            skinNumber = 0;
        else if (skinNumber < 0)
            skinNumber = skins.Length - 1;
    }


    // Update is called once per frame
    void LateUpdate()
    {
        SkinChoice();
        
    }

    void SkinChoice(){
        if (spriteRenderer.sprite.name.Contains("HamsterMain")){
            string spriteName = spriteRenderer.sprite.name;
        spriteName = spriteName.Replace("HamsterMain", "");
        int spriteNumber = int.Parse(spriteName);

        spriteRenderer.sprite = skins[skinNumber].sprites[spriteNumber];
        }
    }

    [System.Serializable]
    public class Skins
    {
        public Sprite[] sprites;
    }
}
