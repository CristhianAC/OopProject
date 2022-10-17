using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outline : MonoBehaviour
{
    public SpriteRenderer parent;
    public SpriteRenderer[] children;
    public Color color;

    // Start is called before the first frame update
    void Start()
    {
        parent = this.gameObject.transform.parent.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        for (int i = 0; i != children.Length; i++)
        {
            children[i].sprite = parent.sprite;
            children[i].color = color;
            children[i].sortingOrder = parent.sortingOrder-1;
        }
    }
}
