using System;
using System.Linq;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Xaml.Controls;
using TextSpeaker.Model;
using TextSpeaker.UWP.Model;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeech))]
namespace TextSpeaker.UWP.Model
{
    public class TextToSpeech : ITextToSpeech
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