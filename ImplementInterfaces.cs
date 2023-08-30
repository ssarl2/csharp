using System.Reflection;

interface IDataBound
{
    void Bind(Binder b);
}

public class EditBox : Icontrol, IDataBound
{
    public void Paint() { }
    public void Bind(Binder b) { }
}