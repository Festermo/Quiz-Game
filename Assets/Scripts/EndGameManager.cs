using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class EndGameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject restartButton;

    [SerializeField]
    private Image fader;

    public void EndGame()
    {
        Physics.queriesHitTriggers = false; //nonclickable cells
        restartButton.SetActive(true);
        fader.DOFade(0.75f, 1);
    }
}