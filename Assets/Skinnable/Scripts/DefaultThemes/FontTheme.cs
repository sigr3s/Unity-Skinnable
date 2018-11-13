using Skinnable;
using UnityEngine;

public class FontTheme : BaseStyle<Font> {
    public Font font;

    public override void ApplyStyle(ref object targetObject)
    {
       if(ShouldApply(nameof(font)) )  targetObject = font;
    }
}