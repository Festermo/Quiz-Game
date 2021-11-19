using UnityEngine;
using DG.Tweening;

public class TwitchAnimation : MonoBehaviour
{
    public void Begin(Transform cellTransform)
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(cellTransform.DOLocalMoveX(-0.015f, 0.05f));
        sequence.Append(cellTransform.DOLocalMoveX(0.015f, 0.05f));
        sequence.Append(cellTransform.DOLocalMoveX(-0.03f, 0.1f));
        sequence.Append(cellTransform.DOLocalMoveX(0.03f, 0.1f));
        sequence.Append(cellTransform.DOLocalMoveX(-0.08f, 0.2f));
        sequence.Append(cellTransform.DOLocalMoveX(0.08f, 0.2f));
        sequence.Append(cellTransform.DOLocalMoveX(-0.12f, 0.15f));
        sequence.Append(cellTransform.DOLocalMoveX(0.12f, 0.15f));
        sequence.Append(cellTransform.DOLocalMoveX(0, 0.1f));
    }
}