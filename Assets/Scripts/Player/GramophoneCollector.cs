using System;
using Audio;
using Player;
using UnityEngine;

public class GramophoneCollector : Interact
{
    private AudioLogSound _audioLogSound;
    private bool[] _hasAudioLogBeenCollected;
    
    public event Action<int> OnGramophoneCollected;

    protected override void Awake()
    {
        base.Awake();
        _audioLogSound = FindObjectOfType<AudioLogSound>();
        _hasAudioLogBeenCollected = new bool[_audioLogSound.sounds.Length];
    }
    protected override void Interaction(Transform item)
    {
        
        var audioIndex = -1;
        switch (item.name)
        {
            case "RecordPlayer1":
                audioIndex = 0;
                break;
            case "RecordPlayer2":
                audioIndex = 1;
                break;
            case "RecordPlayer3":
                audioIndex = 2;
                break;
            case "RecordPlayer4":
                audioIndex = 3;
                break;
            case "RecordPlayer5":
                audioIndex = 4;
                break;
            case "RecordPlayer6":
                audioIndex = 5;
                break;
            case "RecordPlayer7":
                audioIndex = 6;
                break;
            case "RecordPlayer8":
                audioIndex = 7;
                break;
            case "RecordPlayer9":
                audioIndex = 8;
                break;
            case "RecordPlayer10":
                audioIndex = 9;
                break;
            case "RecordPlayer11":
                audioIndex = 10;
                break;
            
        }

        FindObjectOfType<AudioLogSound>().PlayAudioLogSound(audioIndex);
        OnGramophoneCollected?.Invoke(audioIndex);
        _hasAudioLogBeenCollected[audioIndex] = true;
        item.gameObject.SetActive(false);
    }
    
    
    public bool[] HasAudioLogBeenCollected
    {
        get => _hasAudioLogBeenCollected;
        set => _hasAudioLogBeenCollected = value;
    }

    public AudioLogSound AudioLogSound => _audioLogSound;


}
