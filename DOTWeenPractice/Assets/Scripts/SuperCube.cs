using System;
using DG.Tweening;
using UnityEngine;

public class SuperCube : MonoBehaviour
{
    [SerializeField] private Vector3 _targetPozition;
    [SerializeField] private Vector3 _rotatePozition;
    [SerializeField] private float _scale;
    [SerializeField] private float _duration;
    
    private void Start()
    {
        transform.DOMove(_targetPozition, _duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
        transform.DORotate(_rotatePozition, _duration, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
        transform.DOScale(_scale, _duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
        
    }
}