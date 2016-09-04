using System;
using System.Linq;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Xaml.Controls;
using TextSpeaker.Model;
using TextSpeaker.UWP.Model;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeechService))]
namespace TextSpeaker.UWP.Model
{
    public class TextToSpeechService : ITextToSpeechService
    {
        public async void Speak(string message)
        {
            var mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            var stream = await synth.SynthesizeTextToStreamAsync(message);

            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }
    }
}