using System.ComponentModel.DataAnnotations;

namespace demo_blazor_pomodoro.Model
{
    public class PomodoroSettings
    {
        [Required(ErrorMessage = "Especifica o tempo de duração do Pomodoro")]
        [Range(1, 60, ErrorMessage = "O valor do tempo precisar ser entre 1 e 60.")]
        public int PomodoroDuration { get; set; }

        [Range(1, 15, ErrorMessage = "O valor do tempo precisa ser entre 1 e 15.")]
        public int ShortBreak { get; set; }

        [Range(15, 60, ErrorMessage = "O valor do tempo precisa ser entre 15 e 60.")]

        public int LongBreak { get; set; }
    }

    public enum TimerType
    {
        Pomodoro = 1,
        ShortBreak = 2,
        LongBreak = 3
    }
}
