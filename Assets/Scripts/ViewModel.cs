using UnityEngine;
using System;

public class ViewModel : MonoBehaviour
{
    [SerializeField] private Model _model;

    public event Action<string> OnTextChande;
    public event Action<float> NumberChanged;
    public event Action ClearText;

    public void GetButtonOne()
    {
        _model.ButtonOne();
        OnTextChande.Invoke(_model.ViewText);
    }

    public void GetButtonTwo()
    {
        _model.ButtonTwo();
        OnTextChande.Invoke(_model.ViewText);
    }

    public void GetButtonThree()
    {
        _model.ButtonThree();
        OnTextChande.Invoke(_model.ViewText);
    }

    public void GetButtonFour()
    {
        _model.ButtonFour();
        OnTextChande.Invoke(_model.ViewText);
    }

    public void GetButtonFive()
    {
        _model.ButtonFive();
        OnTextChande.Invoke(_model.ViewText);
    }

    public void GetButtonSix()
    {
        _model.ButtonSix();
        OnTextChande.Invoke(_model.ViewText);
    }

    public void GetButtonSeven()
    {
        _model.ButtonSeven();
        OnTextChande.Invoke(_model.ViewText);
    }

    public void GetButtonEight()
    {
        _model.ButtonEight();
        OnTextChande.Invoke(_model.ViewText);
    }

    public void GetButtonNine()
    {
        _model.ButtonNine();
        OnTextChande.Invoke(_model.ViewText);
    }

    public void GetButtonOperator(string opr)
    {
        _model.ButtonOperatores(opr);
        OnTextChande.Invoke(_model.ViewText);
    }

    public void GetButtonAnswer()
    {
        _model.ButtonAnswer();
        NumberChanged.Invoke(_model.Result);
    }

    public void GetButtonClear()
    {
        _model.ButtonClear();
        ClearText.Invoke();
    }

}
