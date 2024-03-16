using DG.Tweening;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loop;
    
    private void Start()
    {
        _renderer.DOColor(_color, _duration).SetLoops(-1 , _loop).SetEase(Ease.Linear);
    }
}