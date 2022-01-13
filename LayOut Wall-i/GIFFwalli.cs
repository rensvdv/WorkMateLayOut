using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayOut_Wall_i
{
    public class GIFFwalli
    {
        public Image GifAfbeelding { get; set; }
        public FrameDimension Dimensie { get; set; }
        public int FrameWaarde { get; set; }
        

        public GIFFwalli(string bestand)
        {
            GifAfbeelding = Image.FromFile(bestand);
            Dimensie = new FrameDimension(GifAfbeelding.FrameDimensionsList[0]);
            FrameWaarde = GifAfbeelding.GetFrameCount(Dimensie);
        }
    }
}