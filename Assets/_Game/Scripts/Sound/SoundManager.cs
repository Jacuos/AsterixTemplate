using UnityEngine;

namespace _Game
{
    public class SoundManager : Manager<SoundManager>
    {
        public AudioSource musicSource;
        public AudioSource sfxSource;

        public SoundConfig config;

        public void PlayCoin()
        {
            sfxSource.PlayOneShot( config.coinSFX );
        }
        
    }
}