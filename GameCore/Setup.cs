using GameCore.Enums;

namespace GameCore
{
    public class Setup
    {
        public ScreenResolution ScreenResolution { get; set; } = ScreenResolution.FullHD;
        public int Brightness { get; set; }
        public int Volume { get; set; }
        public int MouseSpeed { get; set; }
    }
}
