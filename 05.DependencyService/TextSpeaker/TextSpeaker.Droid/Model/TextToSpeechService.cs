using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Speech.Tts;
using Android.Views;
using Android.Widget;
using TextSpeaker.Model;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextSpeaker.Droid.Model.TextToSpeechService))]
namespace TextSpeaker.Droid.Model
{
    public class TextToSpeechService : ITextToSpeechService, TextToSpeech.IOnInitListener
    {
        private TextToSpeech speaker;
        private string toSpeak;

        public void Speak(string message)
        {
            var c = Forms.Context;
            toSpeak = message;
            if (speaker == null)
            {
                speaker = new TextToSpeech(c, this);
            }
            else
            {
                var p = new Dictionary<string, string>();
                speaker.Speak(toSpeak, QueueMode.Flush, p);
            }
        }

        public void Dispose()
        {
            speaker?.Dispose();
        }

        public IntPtr Handle { get; }
        public void OnInit(OperationResult status)
        {
            if (status == OperationResult.Success)
            {
                var p = new Dictionary<string, string>();
                speaker.Speak(toSpeak, QueueMode.Flush, p);
            }
        }
    }
}