using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class ComboResultIndicator : MonoBehaviour
    {
        public Sprite GoodComboSprite;
        public Sprite BadComboSprite;

        public Image ImageReference;

        public void ChangeImageCombo(bool isGoodCombo) => ImageReference.sprite = isGoodCombo ? GoodComboSprite : BadComboSprite;
    }
}