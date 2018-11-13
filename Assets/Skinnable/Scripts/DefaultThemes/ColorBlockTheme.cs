using Skinnable;
using UnityEngine;
using UnityEngine.UI;

public class ColorBlockTheme : BaseStyle<ColorBlock> {

    public Color normalColor  = Color.white;
    public Color highlightedColor  = Color.white;
    public Color pressedColor  = Color.white;
    public Color disabledColor  = Color.white;
    public float colorMultiplier  = 1.0f;
    public float fadeDuration  = 0.1f;

    public override void ApplyStyle(ref object targetObject)
    {
        ColorBlock colorBlock = (ColorBlock) targetObject;

       if(ShouldApply(nameof(normalColor)) )  colorBlock.normalColor = normalColor;
       if(ShouldApply(nameof(highlightedColor)) ) colorBlock.highlightedColor = highlightedColor;
       if(ShouldApply(nameof(pressedColor)) ) colorBlock.pressedColor = pressedColor;
       if(ShouldApply(nameof(disabledColor)) ) colorBlock.disabledColor = disabledColor;
       if(ShouldApply(nameof(colorMultiplier)) ) colorBlock.colorMultiplier = colorMultiplier;
       if(ShouldApply(nameof(fadeDuration)) ) colorBlock.fadeDuration = fadeDuration;

       targetObject = colorBlock;
    }
}