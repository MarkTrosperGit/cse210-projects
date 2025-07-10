public class Simple : Goal
{
    public override string GetSave()
    {
        return $"Simple:{GetName()}|{GetDescription()}|{GetPoints()}|{GetIsComplete()}";
    }
    public override void DisplayForList()
    {
        if (GetIsComplete())
        {
            string isChecked = "X";
            Console.WriteLine($"[{isChecked}] {GetName()} ({GetDescription()})");
        }
        else
        {
            string isChecked = " ";
            Console.WriteLine($"[{isChecked}] {GetName()} ({GetDescription()})");
        }
    }
    public override int RecordEvent()
    {
        if (GetIsComplete() == false)
        {
            SetIsComplete(true);
            return GetPoints();
        }
        return 0;
    }
    public Simple(string name, string description, int points, bool isComplete) : base(name, description, points, isComplete)
    {
    }


}