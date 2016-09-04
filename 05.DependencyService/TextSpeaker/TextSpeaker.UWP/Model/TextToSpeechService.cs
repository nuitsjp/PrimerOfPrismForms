using System;
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
            using (var speech = new SpeechSynthesizer())
            using (var stream = await speech.SynthesizeTextToStreamAsync(message))
            {
                var mediaplayer = new MediaElement();
                mediaplayer.SetSource(stream, stream.ContentType);
                mediaplayer.Play();
            }
        }
    }
}