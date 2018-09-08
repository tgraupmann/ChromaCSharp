using ChromaSDK;
using System.Threading;

namespace ChromaGuideCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseLayer = "Animations/BlackAndWhiteRainbow_Keyboard.chroma";
            CChromaEditorLibrary.CloseAnimationName(baseLayer);
            CChromaEditorLibrary.MultiplyIntensityAllFramesName(baseLayer, 0.25f);
            CChromaEditorLibrary.MultiplyIntensityAllFramesRGBName(baseLayer, 255, 0, 0);
            CChromaEditorLibrary.PlayAnimationName(baseLayer, true);
            while (true)
            {
                Thread.Sleep(0);
            }
        }
    }
}
