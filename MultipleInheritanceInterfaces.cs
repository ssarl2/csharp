interface Icontrol
{
    void Paint();
}

interface ITextBox : Icontrol
{
    void SetText(string text);
}

interface IListBox : Icontrol
{
    void SetItems(string[] items);
}

interface IComboBox : ITextBox, IListBox { }