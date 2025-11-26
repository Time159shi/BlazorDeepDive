namespace ToDoApp.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private bool _isCompleted = false;
        public bool IsCompleted
        {
            get => _isCompleted; 
            set
            {
                _isCompleted = value;
                if (_isCompleted)
                {
                    DateCompleted = DateTime.Now;
                }
            }
        }
        public DateTime DateCompleted { get; set; }
    }
}
