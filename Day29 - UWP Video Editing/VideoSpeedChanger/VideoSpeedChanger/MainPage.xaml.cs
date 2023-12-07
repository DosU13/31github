using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
using Windows.Media.Editing;
using Windows.Media.Effects;
using Windows.Storage.Pickers;
using Windows.Storage;
using Windows.UI.Composition.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace VideoSpeedChanger
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public CompositionController compositionCrtl = new CompositionController();

        public MainPage()
        {
            this.InitializeComponent();
            compositionCrtl.status = Status;
            compositionCrtl.mediaPlayerElement = mediaPlayerElement;
            compositionCrtl.ChangeRender += delegate (object sender, EventArgs arg)
            {
                UpdateMediaElementSource();
            };
        }

        private MediaStreamSource mediaStreamSource;
        public void UpdateMediaElementSource()
        {
            mediaStreamSource = compositionCrtl.composition.GeneratePreviewMediaStreamSource(
                (int)mediaPlayerElement.ActualWidth,
                (int)mediaPlayerElement.ActualHeight);
            mediaPlayerElement.Source = MediaSource.CreateFromMediaStreamSource(mediaStreamSource);
        }

        private async void AddFile_Click(object sender, RoutedEventArgs e)
        {
            await PickFileAndAddClip();
        }

        private async void AddPhotos_Click(object sender, RoutedEventArgs e)
        {
            await PickPhotosAndAddToComp();
        }

        private async void AddEffect_Click(object sender, RoutedEventArgs e)
        {
            await AddEffect();
        }

        private async Task AddEffect()
        {
            var clip = compositionCrtl.composition.Clips.First();
            clip.VideoEffectDefinitions.Add(new VideoEffectDefinition("VideoEffects.Brightness"));
            compositionCrtl.Render();
        }

        private async Task PickFileAndAddClip()
        {
            var picker = new FileOpenPicker();
            picker.SuggestedStartLocation = PickerLocationId.VideosLibrary;
            picker.FileTypeFilter.Add(".mp4");
            StorageFile pickedFile = await picker.PickSingleFileAsync();
            if (pickedFile == null) return;

            // These files could be picked from a location that we won't have access to later
            var storageItemAccessList = Windows.Storage.AccessCache.StorageApplicationPermissions.FutureAccessList;
            storageItemAccessList.Add(pickedFile);

            var clip = await MediaClip.CreateFromFileAsync(pickedFile);

            compositionCrtl.AddClip(clip);
        }

        private async Task PickPhotosAndAddToComp()
        {
            var picker = new FileOpenPicker();
            picker.ViewMode = PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            picker.FileTypeFilter.Add(".jpg");
            picker.FileTypeFilter.Add(".jpeg");
            picker.FileTypeFilter.Add(".png");

            var files = await picker.PickMultipleFilesAsync();
            if (files.Count > 0)
            {
                compositionCrtl.AddPhotos(files);
            }
        }
    }
}
