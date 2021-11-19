using UnityEngine;

public class AnswerChecker : MonoBehaviour
{
    [SerializeField]
    private TaskManager taskManager;

    [SerializeField]
    private TwitchAnimation twitchAnimation;

    [SerializeField]
    private BounceAnimation bounceAnimation;

    public void CheckAnswer(string content, Transform cellTransform)
    {
        if (content == taskManager.currentTask)
            StartCoroutine(bounceAnimation.BounceAndParticle(cellTransform));
        else
            twitchAnimation.Begin(cellTransform);
    }
}