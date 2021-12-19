using AbstractFactoryPattern;

var appConfig = new AppConfiguration();

// Configuration provider

//var uiFactory = appConfig.GetUIConfigurationFactory(UserInterface.Windows);
var uiFactory = appConfig.GetUIConfigurationFactory(UserInterface.Mac);

// Textbox
var textBox = uiFactory.CreateTextBox();
Console.WriteLine(textBox.Text);

// Radio button
var radioButton = uiFactory.CreateRadioButton();
radioButton.Select();

// Button
var button = uiFactory.CreateButton();
button.Click();

// Checkbox
var checkBox = uiFactory.CreateCheckBox();
Console.WriteLine($"Checkbox state = {checkBox.IsChecked}");