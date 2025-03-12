using Emgu.CV.Cuda;
using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UnityEngine.Rendering.DebugUI;
using UnityEngine;

namespace WildfrostHopeMod.Leader_Colour_Test
{
    internal static class MeanshiftTest
    {

        public static void CalcuateMeanshift(Image<Bgra, byte> imgInput, out Image<Bgra, byte> imgOutput, int spatialWindow = 5, int colorWindow = 5, int MinSegmentSize = 20)
        {
            imgOutput = new Image<Bgra, byte>(imgInput.Width, imgInput.Height, new Bgra(0, 0, 0, 0));
            if (imgInput == null)
            {
                Debug.LogWarning("Image input was null, returning early");
                return;
            }
            try
            {
                //convert the image to BGRA as it requires a BGRA to pass it in constructor of CudaImage
                CudaImage<Bgra, byte> _inputCuda = new CudaImage<Bgra, byte>(imgInput);
                CudaInvoke.MeanShiftSegmentation(_inputCuda, imgOutput, spatialWindow, colorWindow, MinSegmentSize, new MCvTermCriteria(1, .001), null);

                Debug.LogWarning("Image success");
            }
            catch (Exception ex)
            {
                Debug.LogError("Meam shift error: " + ex.Message);
            }
        }
    }
}
