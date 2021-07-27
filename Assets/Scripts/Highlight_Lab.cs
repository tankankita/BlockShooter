using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight_Lab : MonoBehaviour
{
    public Color HighlightColor = Color.red;
    private Color _defaultColor;
    private Renderer _renderer;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _defaultColor = GetColor();
    }


    public void ShowHighlight(bool show)
    {
        if(show)
        {
            SetColor(HighlightColor);
        }
        else
        {
            SetColor(_defaultColor);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Color GetColor()
    {
        return _renderer.material.GetColor("_BaseColor");
    }

    private void SetColor(Color color)
    {
        _renderer.material.SetColor("_BaseColor", color);
    }
}
