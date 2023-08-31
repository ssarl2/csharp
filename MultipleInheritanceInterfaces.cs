using System.Reflection;
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

interface IDataBound
{
    void Bind(Binder b);
}

public class EditBox : Icontrol, IDataBound
{
    public void Paint() { }
    public void Bind(Binder b) { }
}