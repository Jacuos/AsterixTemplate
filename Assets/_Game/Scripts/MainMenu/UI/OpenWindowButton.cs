using UnityEngine;
using UnityEngine.UI;

namespace _Game
{
    
    [RequireComponent(typeof(Button))]
    public class OpenWindowButton : MonoBehaviour
    {
        public CanvasGroup windowToOpen;
        public bool close;
        private Button _myButton;
        void Awake()
        {
            _myButton = GetComponent<Button>();
            _myButton.onClick.AddListener( OnButtonClick );
        }

        void OnButtonClick()
        {
            windowToOpen.SetActive( !close );
        }
    }
}