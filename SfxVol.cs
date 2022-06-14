using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SfxVol : MonoBehaviour
{
    public AudioMixer sfxmixer;
    public Slider slider;

    private void Start()
    {
        slider.value = PlayerPrefs.GetFloat("sfxVolume", 0.75f);
    }

    public void SetLevel(float sliderValue)
    {
        sfxmixer.SetFloat("sfxvol", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("sfxVolume", sliderValue);
    }
}
