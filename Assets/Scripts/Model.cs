using UnityEngine;

public class Model : MonoBehaviour
{
    private string _viewText;
    private string _tempText;
    private string _applied;
    private bool isOperator = false;
    private int _inputOne;
    private int _inputTwo;
    private float _result;

    public float Result => _result;
    public string ViewText => _viewText;
    public string TempText => _tempText;
    public string Applied => _applied;

    public void ButtonOne()
    {
        _viewText = _viewText + "1";
        if (isOperator)
            _tempText = _tempText + "1";
    }

    public void ButtonTwo()
    {
        _viewText = _viewText + "2";
        if (isOperator)
            _tempText = _tempText + "2";
    }

    public void ButtonThree()
    {
        _viewText = _viewText + "3";
        if (isOperator)
            _tempText = _tempText + "3";
    }

    public void ButtonFour()
    {
        _viewText = _viewText + "4";
        if (isOperator)
            _tempText = _tempText + "4";
    }

    public void ButtonFive()
    {
        _viewText = _viewText + "5";
        if (isOperator)
            _tempText = _tempText + "5";
    }

    public void ButtonSix()
    {
        _viewText = _viewText + "6";
        if (isOperator)
            _tempText = _tempText + "6";
    }

    public void ButtonSeven()
    {
        _viewText = _viewText + "7";
        if (isOperator)
            _tempText = _tempText + "7";
    }

    public void ButtonEight()
    {
        _viewText = _viewText + "8";
        if (isOperator)
            _tempText = _tempText + "8";
    }

    public void ButtonNine()
    {

        _viewText = _viewText + "9";
        if (isOperator)
            _tempText = _tempText + "9";
    }

    public void ButtonOperatores(string opr)
    {
        _inputOne = System.Convert.ToInt32(_viewText.ToString());
        if (opr == "+")
        {
            _viewText = _viewText + " + ";
            _applied = "+";
        }
        else if (opr == "*")
        {
            _viewText = _viewText + " * ";
            _applied = "*";
        }
        else if (opr == "-")
        {
            _viewText = _viewText + " - ";
            _applied = "-";
        }
        else if (opr == "/")
        {
            _viewText = _viewText + " / ";
            _applied = "/";
        }
        isOperator = true;
    }

    public void ButtonAnswer()
    {
        _inputTwo = System.Convert.ToInt32(_tempText.ToString());

        if (_applied == "+")
        {
           _result = _inputOne + _inputTwo;
        }
        else if (_applied == "-")
        {
            _result = _inputOne - _inputTwo;
        }
        else if (_applied == "/" )
        {
            _result = _inputOne / _inputTwo;
        }
        else if (_applied == "*")
        {
            _result = _inputOne * _inputTwo;
        }
    }

    public void ButtonClear()
    {
        _viewText = _tempText = _applied = null;
        _inputOne = _inputTwo = 0;
        isOperator = false;
    }
}
