using UnityEngine;

namespace TestViewer
{
    public class RobotHandler : MonoBehaviour
    {
        [SerializeField] AudioSource audioSource;

        /// <summary>
        /// Play the bionic clip.
        /// </summary>
        public void PlayBionicSound()
        {
            audioSource.Play();
        }
    }
}