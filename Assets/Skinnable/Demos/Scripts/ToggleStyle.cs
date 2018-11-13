using System;
using Skinnable;
using UnityEngine;
using UnityEngine.UI;

public class ToggleStyle : BaseStyle<Toggle> {
    public ColorBlock colorBlock;

    public Sprite toggleSprite;

    public override void ApplyStyle(ref System.Object targetObject)
    {
        Toggle toggle = targetObject as Toggle;
        if (toggle != null) {

            if(ShouldApply(nameof(colorBlock))) toggle.colors = colorBlock;

            if(ShouldApply(nameof(toggleSprite))){
                Image image = toggle.targetGraphic as Image;
                if(image != null) image.sprite = toggleSprite;
            }
        }
    }

}