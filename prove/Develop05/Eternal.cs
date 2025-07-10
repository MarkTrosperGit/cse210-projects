public class Eternal : Goal
{
    public override string GetSave()
    {
        return $"Eternal:{GetName()}|{GetDescription()}|{GetPoints()}|{GetIsComplete()}";
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
            return GetPoints();
        }
        return 0;
    }
    public Eternal(string name, string description, int points, bool isComplete) : base(name, description, points, isComplete)
    {
        
    }
}