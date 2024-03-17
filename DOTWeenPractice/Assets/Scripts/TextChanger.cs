using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    [SerializeField] private string _newText;
    [SerializeField] private string _additionText;
    [SerializeField] private string _hackedText;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.SetEase(Ease.Linear);
        sequence.Append(_text.DOText(_newText, _duration));
        sequence.Append(_text.DOText(_additionText, _duration).SetRelative());
        sequence.Append(_text.DOText(_hackedText, _duration, true, ScrambleMode.All));
        sequence.SetLoops(-1, LoopType.Incremental);
    }
}