using System;

using FizzBuzz.V2;

using UnityEngine;
using UnityEngine.UI;

public class FizzBuzzUI : MonoBehaviour
{
	#region Private Fields

	[SerializeField] private InputField _minRangeValueInputField;
	[SerializeField] private InputField _maxRangeValueInputField;
	[SerializeField] private Text _fizzBuzzResultHeaderText;
	[SerializeField] private Text _fizzBuzzResultText;
	[SerializeField] private ScrollRect _fizzBuzzResultScrollView;

	private FizzBuzzGenerator _fizzBuzzGenerator;
	private string fizzBuzzResult;

	#endregion

	#region Public Methods

	public void OnGenerateFizzBuzzButtonClick()
	{
		try
		{
			fizzBuzzResult = _fizzBuzzGenerator.GenerateFizzBuzzForRange(_minRangeValueInputField.text, _maxRangeValueInputField.text);
		}
		catch (ArgumentException argumentException)
		{
			fizzBuzzResult = argumentException.Message;
		}

		_fizzBuzzResultHeaderText.text = $"FIZZ - BUZZ RESULT FOR RANGE {_fizzBuzzGenerator.Range}:";
		_fizzBuzzResultText.text = fizzBuzzResult;

		_fizzBuzzResultScrollView.verticalScrollbar.value = 1;
		LayoutRebuilder.ForceRebuildLayoutImmediate(_fizzBuzzResultScrollView.content);
	}

	public void OnCloseButtonClick() => Application.Quit();

	#endregion

	#region Private Methods

	private void Start()
	{
		_fizzBuzzGenerator = new FizzBuzzGenerator();
	}

	#endregion
}
