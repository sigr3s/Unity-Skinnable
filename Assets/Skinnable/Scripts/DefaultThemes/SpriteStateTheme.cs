using Skinnable;
using UnityEngine;
using UnityEngine.UI;

public class SpriteStateTheme : BaseStyle<SpriteState>
{
    public Sprite highlightedSprite;
    public Sprite pressedSprite;
    public Sprite disabledSprite;

    public override void ApplyStyle(ref object targetObject)
    {
        SpriteState spriteState = (SpriteState) targetObject;
        if(ShouldApply(nameof(highlightedSprite)) )  spriteState.highlightedSprite = highlightedSprite;
        if(ShouldApply(nameof(pressedSprite)) ) spriteState.pressedSprite = pressedSprite;
        if(ShouldApply(nameof(disabledSprite)) ) spriteState.disabledSprite = disabledSprite;

        targetObject = spriteState;
    }
    
}