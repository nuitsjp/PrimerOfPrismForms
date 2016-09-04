using System;
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
            using (var synth = new SpeechSynthesizer())
            using (var stream = await synth.SynthesizeTextToStreamAsync(message))
            {
                var mediaElement = new MediaElement();
                mediaElement.SetSource(stream, stream.ContentType);
                mediaElement.Play();
            }
        }
    }
}