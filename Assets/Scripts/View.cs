using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class View : MonoBehaviour
{
    [SerializeField] private ViewModel _viewModel;
    [SerializeField] private TMP_Text _resultText;

    private void OnEnable()
    {
        _viewModel.OnTextChande += UpdateText;
        _viewModel.NumberChanged += UpdateNumber;
        _viewModel.ClearText += ClearText;
    }

    private void OnDisable()
    {
        _viewModel.OnTextChande -= UpdateText;
        _viewModel.NumberChanged -= UpdateNumber;
        _viewModel.ClearText -= ClearText;
    }

    private void ClearText()
    {
        _resultText.text = "";
    }

    private void UpdateNumber(float result)
    {
        _resultText.text = result.ToString();
    }

    private void UpdateText(string viewText)
    {
        _resultText.text = viewText.ToString();
    }
}
