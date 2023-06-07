using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewSchoolGameLogic : MonoBehaviour
{
    public TMP_Text storyContent;
    public StorySegments startingStorySegment;
    private StorySegments _currentStorySegment;
    
    // Start is called before the first frame update
    void Start()
    {
        _currentStorySegment = startingStorySegment;
        storyContent.text = _currentStorySegment.storyText;
    }

    // Update is called once per frame
    void Update()
    {
        var nextStorySegment = _currentStorySegment.nextStorySegment;

        for (int i = 0; i < nextStorySegment.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                _currentStorySegment = nextStorySegment[i];
            }
        }

        if (_currentStorySegment.storyText != "Exit Game")
        {
            storyContent.text = _currentStorySegment.storyText;
        }
        else
        {
            ExitGame();
        }
    }
    
    private void ExitGame()
    {
        Application.Quit();
        Debug.Log("App Quit");
    } 
}
