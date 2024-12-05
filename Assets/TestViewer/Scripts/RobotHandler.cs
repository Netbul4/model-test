using UnityEngine;

namespace TestViewer
{
    public class RobotHandler : MonoBehaviour
    {
        #region VARIABLES
        [SerializeField] ParticleSystem smokeLeft, smokeRight;
        [SerializeField] AudioSource audioSource;
        #endregion

        #region FUNCTIONS
        /// <summary>
        /// Play the bionic clip.
        /// </summary>
        public void PlayBionicSound()
        {
            audioSource.Play();
        }

        /// <summary>
        /// Start the smoke emission effect.
        /// </summary>
        private void StartSmokeEmission()
        {
            smokeLeft.Play();
            smokeRight.Play();
        }

        private void Start()
        {
            Invoke(nameof(StartSmokeEmission), 25);
        }
        #endregion
    }
}