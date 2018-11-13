using Skinnable;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ColorTheme : BaseStyle<Color> {
    public Color color = Color.white;
    public override void ApplyStyle (ref System.Object targetObject) {
        if(ShouldApply(nameof(color)) ) targetObject = color;
    }

}