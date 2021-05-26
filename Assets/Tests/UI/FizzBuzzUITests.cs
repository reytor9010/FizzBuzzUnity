using System;
using System.Collections;

using NUnit.Framework;

using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace FizzBuzzTest.UI
{
	public class FizzBuzzUITests : InputTestFixture
	{
		#region Private Fields

		private Mouse _mouse;
		private Keyboard _keyboard;

		#endregion

		#region SetUp

		[SetUp]
		public override void Setup()
		{
			base.Setup();

			SceneManager.LoadScene("FizzBuzzScene");

			_mouse = InputSystem.AddDevice<Mouse>();
			_keyboard = InputSystem.AddDevice<Keyboard>();
		}

		#endregion

		#region Public Methods

		[UnityTest]
		public IEnumerator MinRangeValueInputField_OnValueChange_OnValueChangeCallbackExecuted()
		{
			bool minRangeValueInputFieldValueChanged = false;
			InputField minRangeValueInputField = GameObject.Find("MinRangeValueInputField").GetComponent<InputField>();

			minRangeValueInputField.text = "";
			minRangeValueInputField.onValueChanged.AddListener((value) => minRangeValueInputFieldValueChanged = value == "a");
			KeyboardTextInput(_keyboard, (value) => minRangeValueInputField.text += value, 'a');
			yield return new WaitForSeconds(0.1f);

			Assert.IsTrue(minRangeValueInputFieldValueChanged);
		}

		[UnityTest]
		public IEnumerator MaxRangeValueInputField_OnValueChange_OnValueChangeCallbackExecuted()
		{
			bool maxRangeValueInputFieldValueChanged = false;
			InputField maxRangeValueInputField = GameObject.Find("MaxRangeValueInputField").GetComponent<InputField>();

			maxRangeValueInputField.text = "";
			maxRangeValueInputField.onValueChanged.AddListener((value) => maxRangeValueInputFieldValueChanged = value == "a");
			KeyboardTextInput(_keyboard, (value) => maxRangeValueInputField.text += value, 'a');
			yield return new WaitForSeconds(0.1f);

			Assert.IsTrue(maxRangeValueInputFieldValueChanged);
		}

		[UnityTest]
		[TestCase("a", "a", ExpectedResult = null)]
		[TestCase("ab", "ab", ExpectedResult = null)]
		[TestCase("abc", "abc", ExpectedResult = null)]
		[TestCase("abcd", "abc", ExpectedResult = null)]
		public IEnumerator MinRangeValueInputField_OnValueChange_OnlyLessThan4CharactersStringsAllowed(string input, string result)
		{
			InputField minRangeValueInputField = GameObject.Find("MinRangeValueInputField").GetComponent<InputField>();

			minRangeValueInputField.text = "";
			KeyboardTextInput(_keyboard, (value) => minRangeValueInputField.text += value, input);
			yield return new WaitForSeconds(0.1f);

			Assert.IsTrue(minRangeValueInputField.text == result);
		}

		[UnityTest]
		[TestCase("a", "a", ExpectedResult = null)]
		[TestCase("ab", "ab", ExpectedResult = null)]
		[TestCase("abc", "abc", ExpectedResult = null)]
		[TestCase("abcd", "abc", ExpectedResult = null)]
		public IEnumerator MaxRangeValueInputField_OnValueChange_OnlyLessThan4CharactersStringsAllowed(string input, string result)
		{
			InputField maxRangeValueInputField = GameObject.Find("MaxRangeValueInputField").GetComponent<InputField>();

			maxRangeValueInputField.text = "";
			KeyboardTextInput(_keyboard, (value) => maxRangeValueInputField.text += value, input);
			yield return new WaitForSeconds(0.1f);

			Assert.IsTrue(maxRangeValueInputField.text == result);
		}

		[UnityTest]
		public IEnumerator GenerateFizzBuzzButton_OnClick_OnClickCallbackExecuted()
		{
			bool generateFizzBuzzButtonClicked = false;
			Button generateFizzBuzzButton = GameObject.Find("GenerateFizzBuzzButton").GetComponent<Button>();

			generateFizzBuzzButton.onClick.AddListener(() => generateFizzBuzzButtonClicked = true);
			ClickOnUIElement("GenerateFizzBuzzButton");
			yield return new WaitForSeconds(0.1f);

			Assert.IsTrue(generateFizzBuzzButtonClicked);
		}

		[UnityTest]
		[TestCase("0", "0", "FizzBuzz", ExpectedResult = null)]
		[TestCase("0", "1", "FizzBuzz\n1", ExpectedResult = null)]
		[TestCase("0.2", "2.8", "FizzBuzz\n1\n2\nFizz", ExpectedResult = null)]
		public IEnumerator GenerateFizzBuzzButton_OnClick_FizzBuzzResultTextIsValid(string minRangeValue, string maxRangeValue, string fizzBuzzResult)
		{
			InputField minRangeValueInputField = GameObject.Find("MinRangeValueInputField").GetComponent<InputField>();
			InputField maxRangeValueInputField = GameObject.Find("MaxRangeValueInputField").GetComponent<InputField>();
			Button generateFizzBuzzButton = GameObject.Find("GenerateFizzBuzzButton").GetComponent<Button>();
			Text fizzBuzzResultText = GameObject.Find("FizzBuzzResultText").GetComponent<Text>();

			minRangeValueInputField.text = "";
			maxRangeValueInputField.text = "";
			KeyboardTextInput(_keyboard, (value) => minRangeValueInputField.text += value, minRangeValue);
			KeyboardTextInput(_keyboard, (value) => maxRangeValueInputField.text += value, maxRangeValue);
			ClickOnUIElement("GenerateFizzBuzzButton");
			yield return new WaitForSeconds(0.2f);

			Assert.IsTrue(fizzBuzzResultText.text == fizzBuzzResult);
		}

		[UnityTest]
		public IEnumerator CloseButton_OnClick_OnClickCallbackExecuted()
		{
			bool closeButtonClicked = false;
			Button closeButton = GameObject.Find("CloseButton").GetComponent<Button>();

			closeButton.onClick.AddListener(() => closeButtonClicked = true);
			ClickOnUIElement("CloseButton");
			yield return new WaitForSeconds(0.1f);

			Assert.IsTrue(closeButtonClicked);
		}

		#endregion

		#region Private Methods

		private void ClickOnUIElement(string name)
		{
			GameObject uiElement = GameObject.Find(name);

			Set(_mouse.position, uiElement.transform.position);
			Click(_mouse.leftButton);
		}

		private void ClickOnUIElement(GameObject uiElement)
		{
			Set(_mouse.position, uiElement.transform.position);
			Click(_mouse.leftButton);
		}

		private void KeyboardTextInput(Keyboard keyboard, string textInput)
		{
			char[] characters = textInput.ToCharArray();

			foreach (char character in characters)
			{
				keyboard.OnTextInput(character);
			}
		}

		private void KeyboardTextInput(Keyboard keyboard, params char[] textInput)
		{
			foreach (char character in textInput)
			{
				keyboard.OnTextInput(character);
			}
		}

		private void KeyboardTextInput(Keyboard keyboard, Action<char> onTextInput, string textInput)
		{
			keyboard.onTextInput += onTextInput;

			KeyboardTextInput(keyboard, textInput);

			keyboard.onTextInput -= onTextInput;
		}

		private void KeyboardTextInput(Keyboard keyboard, Action<char> onTextInput, params char[] textInput)
		{
			keyboard.onTextInput += onTextInput;

			KeyboardTextInput(keyboard, textInput);

			keyboard.onTextInput -= onTextInput;
		}

		#endregion
	}
}
