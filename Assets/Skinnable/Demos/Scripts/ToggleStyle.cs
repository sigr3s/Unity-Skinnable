using System;
using Skinnable;
using UnityEngine;
using UnityEngine.UI;

public class ToggleStyle : BaseStyle<Toggle> {
    public Color normalColor = Color.white;
    public Color highlightedColor = Color.white;
    public Color pressedColor = Color.white;
    public Color disabledColor = Color.white;

    public Sprite buttonSprite;

    public override void ApplyStyle(ref System.Object targetObject)
    {
        Toggle toggle = targetObject as Toggle;
        if (toggle != null) {
            ColorBlock cb = toggle.colors;
            if(ShouldApply(nameof(normalColor)) ) cb.normalColor = normalColor;
            if(ShouldApply(nameof(highlightedColor)) ) cb.highlightedColor = highlightedColor;
            if(ShouldApply(nameof(pressedColor)) ) cb.pressedColor = pressedColor;
            if(ShouldApply(nameof(disabledColor)) ) cb.disabledColor = disabledColor;
            toggle.colors = cb;
            if(ShouldApply(nameof(buttonSprite))){
                Image image = toggle.targetGraphic as Image;
                if(image != null) image.sprite = buttonSprite;
            }
        }
    }

}