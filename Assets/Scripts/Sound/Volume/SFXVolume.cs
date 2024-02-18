using YG;

namespace WKMR
{
    public class SFXVolume : VolumeChanger
    {
        protected override float GetValue() => YandexGame.savesData.SFXVolume;

        protected override void SaveVolume()
        {
            YandexGame.savesData.SFXVolume = Slider.value;
            YandexGame.SaveProgress();
        }
    }
}