using CinemaSeatingBooking.UI;

namespace CinemaSeatingBooking.Controller
{
    public class InputMessageController
    {
        public event EventHandler<int>? ProcessCompleted;
        private bool _success;
        private string? _cmdInput;
        private int _validCmdInput;
        public void AskUserUntilInputIsValid<T>(T TextToDisplay)
        {
            _success = false;
            while (!_success)
            {
                Console.Write($"\r{TextToDisplay}");
                _ = int.TryParse(_cmdInput = Console.ReadLine()!, out _validCmdInput) ? _success = true : Helpers.ParameterErrorHandler(_cmdInput);
                Helpers.ClearConsoleLinesAbove(1);
            }
            OnProcessCompleted(_validCmdInput);
        }

        public string DisplayObjectTypeMenu<T>(T DisplayText, Func<Dictionary<string, Action>, string> dictsMenuMethod, Dictionary<string, Action> keyValues)
        {
            Console.Write($"\r{DisplayText}");
            return dictsMenuMethod(keyValues);
        }
        protected virtual void OnProcessCompleted(int successfulResult)
        {
            ProcessCompleted?.Invoke(this, successfulResult);
        }
    }
}
