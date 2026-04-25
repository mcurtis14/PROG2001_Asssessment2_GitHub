using UnityEngine;

public class AmbienceSwitcher : MonoBehaviour
{
    public AudioSource landAudio;
    public AudioSource waterAudio;

    void Start()
    {
        if (landAudio != null)
        {
            landAudio.Play();
        }

        if (waterAudio != null)
        {
            waterAudio.Stop();
        }
    }

    public void EnterWater()
    {
        if (landAudio != null && landAudio.isPlaying)
        {
            landAudio.Stop();
        }

        if (waterAudio != null && !waterAudio.isPlaying)
        {
            waterAudio.Play();
        }
    }

    public void ExitWater()
    {
        if (waterAudio != null && waterAudio.isPlaying)
        {
            waterAudio.Stop();
        }

        if (landAudio != null && !landAudio.isPlaying)
        {
            landAudio.Play();
        }
    }
}