using System.Collections.Generic;
using Android.Speech.Tts;
using TextSpeaker.Model;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextSpeaker.Droid.Model.TextToSpeech))]
namespace TextSpeaker.Droid.Model
{
    public class TextToSpeech : Java.Lang.Object, ITextToSpeech, Android.Speech.Tts.TextToSpeech.IOnInitListener
    {
        private Android.Speech.Tts.TextToSpeech _speaker;
        private string _message;

        public void Speak(string message)
        {
            var c = Forms.Context;
            _message = message;
            if (_speaker == null)
            {
                _speaker = new Android.Speech.Tts.TextToSpeech(c, this);
            }
            else
            {
                var p = new Dictionary<string, string>();
                _speaker.Speak(_message, QueueMode.Flush, p);
            }
        }

        public void OnInit(OperationResult status)
        {
            if (status == OperationResult.Success)
            {
                var p = new Dictionary<string, string>();
                _speaker.Speak(_message, QueueMode.Flush, p);
            }
        }
    }
}