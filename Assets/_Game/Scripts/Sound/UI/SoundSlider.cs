using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace _Game
{
    public class SoundSlider : MonoBehaviour
    {
        public string soundPropertyName;
        public AudioMixer mixer;
        private Slider _mySlider;

        void Start()
        {
            _mySlider = GetComponentInChildren<Slider>();
            _mySlider.onValueChanged.AddListener( OnSlider );
            LoadProperty();
        }


        void OnSlider(float sliderValue)
        {
            mixer.SetFloat( soundPropertyName, sliderValue );
            SaveProperty();
        }

        void LoadProperty()
        {
            float value = PlayerPrefs.GetFloat( SaveKeys.SOUND_OPTION + soundPropertyName,_mySlider.value );
            _mySlider.value = value;
        }

        void SaveProperty()
        {
            PlayerPrefs.SetFloat(SaveKeys.SOUND_OPTION + soundPropertyName,_mySlider.value);
        }
    }
}