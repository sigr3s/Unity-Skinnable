using Skinnable;
using UnityEngine;

public class SpriteTheme : BaseStyle<Sprite> {
    public Sprite sprite;
    public override void ApplyStyle (ref System.Object targetObject) {
        if(ShouldApply(nameof(sprite)) ) targetObject = sprite;
    }
}