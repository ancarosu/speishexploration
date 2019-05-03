using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Portrait : MonoBehaviour {

    public SpriteRenderer spriteRenderer;

    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.DOFade(1f, 1f);
    }


    void OnEnable()
    {
        spriteRenderer.DOFade(1f, 1f);
    }

    void OnDisable()
    {
        spriteRenderer.DOFade(0.0f, 1f);
    }
}
