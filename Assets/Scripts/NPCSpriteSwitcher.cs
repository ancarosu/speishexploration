using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

[RequireComponent(typeof(SpriteRenderer))]
/// Attach SpriteSwitcher to game object
public class NPCSpriteSwitcher : MonoBehaviour
{

    [System.Serializable]
    public struct SpriteInfo
    {
        public string name;
        public Sprite sprite;
    }

    public SpriteInfo[] sprites;

    /// Create a command to use on a sprite
    [YarnCommand("setnpcportrait")]
    public void UseSprite(string spriteName)
    {
        Debug.Log(spriteName);
        Sprite s = null;
        foreach (var info in sprites)
        {
            if (info.name == spriteName)
            {
                s = info.sprite;
                break;
            }
        }
        if (s == null)
        {
            Debug.LogErrorFormat("Can't find sprite named {0}!", spriteName);
            return;
        }

        GetComponent<SpriteRenderer>().sprite = s;
    }
}