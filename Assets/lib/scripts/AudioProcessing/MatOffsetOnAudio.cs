using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatOffsetOnAudio : MonoBehaviour
{

    AudioSpectrum _audioSpectrum;
    public bool _useBuffer;
    public Material _material;
    public int _band = 0;
    float offset = 0;
    float scrollSpeed = 0.5f;
    public float _scalar = 0.1f;

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
            scrollSpeed = _audioSpectrum._AmplitudeBuffer * _scalar;
            offset += Time.deltaTime * scrollSpeed;
            _material.mainTextureOffset = new Vector2(0, offset);
        }

        if (!_useBuffer)
        {
            // _material.SetColor("_EmissionColor", _color);
        }
    }
}
