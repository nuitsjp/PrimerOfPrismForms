using System;
using System.Collections.Generic;
using System.Text;
using AVFoundation;
using TextSpeaker.iOS.Model;
using TextSpeaker.Model;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeechService))]
namespace TextSpeaker.iOS.Model
{
    public class TextToSpeechService : ITextToSpeechService
    {
        public void Speak(string message)
        {
            var speechSynthesizer = new AVSpeechSynthesizer();

            var speechUtterance = new AVSpeechUtterance(message)
            {
                Rate = AVSpeechUtterance.MaximumSpeechRate / 4,
                Voice = AVSpeechSynthesisVoice.FromLanguage("en-US"),
                Volume = 0.5f,
                PitchMultiplier = 1.0f
            };

            speechSynthesizer.SpeakUtterance(speechUtterance);
        }
    }
}
