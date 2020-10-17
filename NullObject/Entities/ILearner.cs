namespace NullObject.Entities
{
    public interface ILearner
    {
        int Id { get; }
        string UserName { get; }
        int CoursesCompleted { get; }
    }
    class NullLearner:ILearner
    {
        public int Id { get; } = 1;
        public string UserName { get; } = "MN";
        public int CoursesCompleted { get; } = 0;

    }
}