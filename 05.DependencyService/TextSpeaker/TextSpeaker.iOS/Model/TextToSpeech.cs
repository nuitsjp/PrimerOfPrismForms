using AVFoundation;
using TextSpeaker.iOS.Model;
using TextSpeaker.Model;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeech))]
namespace TextSpeaker.iOS.Model
{
    public class TextToSpeech : ITextToSpeech
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
