namespace CityFix.Models
{
    // Одна міська заявка (рядок таблиці requests разом із назвами з інших таблиць)
    public class Request
    {
        public int Id { get; set; }
        public string ResidentName { get; set; }
        public string Phone { get; set; }
        public string District { get; set; }
        public string Category { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string BrigadeName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime Deadline { get; set; }

        // Заявка прострочена, якщо термін минув, а вона ще не виконана і не відхилена
        public bool IsOverdue
        {
            get
            {
                if (Status == "Виконана" || Status == "Відхилена")
                    return false;
                return DateTime.Now > Deadline;
            }
        }

        // Текст для користувача: скільки часу залишилось або на скільки прострочено
        public string TimeLeftText()
        {
            if (Status == "Виконана" || Status == "Відхилена")
                return Status;

            TimeSpan left = Deadline - DateTime.Now;
            if (left.TotalMinutes < 0)
                return "ПРОСТРОЧЕНО на " + (int)(-left.TotalHours) + " год";

            return "Залишилось " + (int)left.TotalHours + " год " + left.Minutes + " хв";
        }
    }
}
