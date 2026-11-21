using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Cutscene : MonoBehaviour
{
    public List<Sprite> sprites = new List<Sprite>();
    public List<string> dialogue = new List<string>();
    private bool canSpeak = false;
    private bool isSpeaking = true;
    private GameObject _talkPanel;
    public TextMeshProUGUI _talkText;
    public Image cutsceneImage;
    private int _talkIndex = 0;

    private void Start()
    {

        _talkPanel = GameObject.Find(HW3Structs.GameObjects.talkPanel);
        //_talkPanel.SetActive(false);
        _talkText.text = dialogue[0];
        cutsceneImage.sprite = sprites[0];

    }

    // Update is called once per frame
    void Update()
    {
        if (isSpeaking && Input.GetKeyDown(KeyCode.E))
        {
            if (dialogue.Count - 1 == _talkIndex)
            {
                isSpeaking = false;
               // _talkPanel.SetActive(false);
            }
            else
            {
                _talkIndex++;
                _talkText.text = dialogue[_talkIndex];
                cutsceneImage.sprite = sprites[_talkIndex];
            }
        }
        else if (canSpeak && Input.GetKeyDown(KeyCode.E))
        {
            isSpeaking = true;
            //_talkPanel.SetActive(true);
            _talkIndex = 0;
            _talkText.text = dialogue[_talkIndex]; 
        }
    }

    public void SetCanSpeak(bool newCanSpeak)
    {
        canSpeak = newCanSpeak;
    }

    public bool IsSpeaking()
    {
        return isSpeaking;
    }

    public void CopyDialogue(List<string> newDialogue)
    {
        dialogue.Clear();
        dialogue.AddRange(newDialogue);
    }
}
