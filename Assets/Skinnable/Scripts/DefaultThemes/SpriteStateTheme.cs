using UnityEngine;
using UnityEngine.UI;

namespace Skinnable
{
    public class SpriteStateTheme : BaseStyle<SpriteState>
    {
        public Sprite highlightedSprite;
        public Sprite pressedSprite;
        public Sprite disabledSprite;

        public override void ApplyStyle(ref object targetObject)
        {
            SpriteState spriteState = (SpriteState) targetObject;
            if(ShouldApply(this.nameof(st => st.highlightedSprite)) )
            {
                spriteState.highlightedSprite = highlightedSprite;
            }

            if(ShouldApply(this.nameof(st => st.pressedSprite)) )
            {
                spriteState.pressedSprite = pressedSprite;
            }

            if(ShouldApply(this.nameof(st => st.disabledSprite)) )
            {
                spriteState.disabledSprite = disabledSprite;
            }


            targetObject = spriteState;
        }
    }
}