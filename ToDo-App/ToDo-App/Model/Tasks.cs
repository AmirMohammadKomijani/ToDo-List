namespace ToDo_App.Model
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Starred { get; set; }
        public bool Checked { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

    }
}
