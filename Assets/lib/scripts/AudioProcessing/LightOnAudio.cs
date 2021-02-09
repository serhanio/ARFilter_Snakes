using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Light))]
public class LightOnAudio : MonoBehaviour
{
    public int _band;
    public float _minIntensity, _maxIntensity;
    Light _light;
    AudioSpectrum _audioSpectrum;

	void Start ()
    {
        _light = GetComponent<Light>();
        _audioSpectrum = FindObjectOfType<AudioSpectrum>();
	}
	
	void Update ()
    {
        _light.intensity = (_audioSpectrum._audioBandBuffer[_band] * (_maxIntensity - _minIntensity)) + _minIntensity;
	}
}
