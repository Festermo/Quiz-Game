using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField]
    private IsClickedGameEvent isClickedGameEvent;

    private string content;

    private void OnMouseDown()
    {
        isClickedGameEvent.Raise(content, transform.GetChild(0).transform); //sends singal to AnswerChecker
    }

    public void SetContent(string value)
    {
        content = value;
    }
}