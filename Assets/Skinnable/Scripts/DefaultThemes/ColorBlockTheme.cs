using UnityEngine;
using UnityEngine.UI;

namespace Skinnable {
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

            if(ShouldApply(this.nameof(b => b.normalColor)) )
            {
                colorBlock.normalColor = normalColor;
            }

            if(ShouldApply(this.nameof(b => b.highlightedColor)) )
            {
                colorBlock.highlightedColor = highlightedColor;
            }

            if(ShouldApply(this.nameof(b => b.pressedColor)) )
            {
                colorBlock.pressedColor = pressedColor;
            }

            if(ShouldApply(this.nameof(b => b.disabledColor)) )
            {
                colorBlock.disabledColor = disabledColor;
            }

            if(ShouldApply(this.nameof(b => b.colorMultiplier)) )
            {
                colorBlock.colorMultiplier = colorMultiplier;
            }

            if(ShouldApply(this.nameof(b => b.fadeDuration)) ){
                colorBlock.fadeDuration = fadeDuration;
            }

        targetObject = colorBlock;
        }
    }
}