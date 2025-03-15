using UnityEngine;
using UnityEngine.UI;

namespace _Game
{
    [RequireComponent(typeof(Button))]
    public class ExitGameButton : MonoBehaviour
    {
        private Button _button;

        void Awake()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener( OnButtonClick );
        }

        void OnButtonClick()
        {
            Application.Quit();
        }
    }
}