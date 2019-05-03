using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Yarn.Unity;
using DG.Tweening;

public class Clickable : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;

    public string characterName = "";

    [FormerlySerializedAs("startNode")]
    public string talkToNode = "";

    [Header("Optional")]
    public TextAsset scriptToLoad;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (scriptToLoad != null)
        {
            FindObjectOfType<Yarn.Unity.DialogueRunner>().AddScript(scriptToLoad);
        }

        spriteRenderer.DOColor(new Color(0.9f, 0.9f, 0.9f, 1f), 0.1f);
    }

    void OnMouseOver()
    {
        Debug.Log("over");
        spriteRenderer.DOColor(Color.white, 0.1f);
    }

    void OnMouseExit()
    {
        spriteRenderer.DOColor(new Color(0.9f, 0.9f, 0.9f, 1f), 0.1f);
    }

    void OnMouseDown()
    {
        FindObjectOfType<Yarn.Unity.DialogueRunner>().StartDialogue(talkToNode);
    }

    void OnEnable()
    {
        spriteRenderer.DOColor(new Color(0.9f, 0.9f, 0.9f, 1f), 1f);
    }

    void OnDisable()
    {
        spriteRenderer.DOFade(0.0f, 1f);
    }
}
