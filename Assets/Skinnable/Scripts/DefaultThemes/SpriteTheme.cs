using UnityEngine;

namespace Skinnable
{
    public class SpriteTheme : BaseStyle<Sprite> {
        public Sprite sprite;
        public override void ApplyStyle (ref System.Object targetObject) {
            if(ShouldApply(this.nameof(s => s.sprite)) )
            {
                targetObject = sprite;
            }
        }
    }
}