using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialGlowOnAudio : MonoBehaviour
{

    AudioSpectrum _audioSpectrum;
    public bool _useBuffer;
    public Material _material;
    public float _red, _green, _blue;
    public int _band = 0;
    public int _matIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        _audioSpectrum = FindObjectOfType<AudioSpectrum>();
        // _material = GetComponent<MeshRenderer>().materials[_matIndex];
    }

    // Update is called once per frame
    void Update()
    {
        if (_useBuffer)
        {
            Color _color = new Color(_red * _audioSpectrum._audioBandBuffer[_band], _green * _audioSpectrum._audioBandBuffer[_band], _blue * _audioSpectrum._audioBandBuffer[_band]);
            _material.SetColor("_EmissionColor", _color);
        }

        if (!_useBuffer)
        {
            Color _color = new Color (_red * _audioSpectrum._audioBand[_band], _green * _audioSpectrum._audioBand[_band], _blue * _audioSpectrum._audioBand[_band]);
            _material.SetColor("_EmissionColor", _color);
        }
    }
}
