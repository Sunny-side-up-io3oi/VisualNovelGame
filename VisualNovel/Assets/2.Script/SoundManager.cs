using Yarn.Unity;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip pianoIntroClip;
    public AudioClip pianoDarkClip;
    public AudioClip heartbeatClip;
    public AudioClip mysteriousThemeClip;

    [YarnCommand("playSound")]
    public void PlaySound(string clipName)
    {
        switch (clipName)
        {
            case "piano_intro":
                audioSource.PlayOneShot(pianoIntroClip);
                break;
            case "piano_dark":
                audioSource.PlayOneShot(pianoDarkClip);
                break;
            case "heartbeat":
                audioSource.PlayOneShot(heartbeatClip);
                break;
            case "mysterious_theme":
                audioSource.PlayOneShot(mysteriousThemeClip);
                break;
            default:
                Debug.LogWarning("해당 사운드 클립을 찾을 수 없습니다: " + clipName);
                break;
        }
    }
}
