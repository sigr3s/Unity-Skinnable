using System;
using UnityEngine;
using UnityEngine.UI;

namespace Skinnable{
    public class ButtonStyle : BaseStyle<Button>
    {
        public ColorBlock buttonColorBlock;
        public SpriteState spriteState;

        public Sprite buttonSprite;

        public override void ApplyStyle(ref System.Object targetObject)
        {
            Button button = targetObject as Button;
            if (button != null) {
                if(ShouldApply(nameof(buttonColorBlock))) button.colors = buttonColorBlock;
                if(ShouldApply(nameof(spriteState))) button.spriteState = spriteState;

                if(ShouldApply(nameof(buttonSprite))){
                    Image image = button.targetGraphic as Image;
                    if(image != null) image.sprite = buttonSprite;
                }
            }
        }
    }
}