using Challenge.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Content
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string PrettyURL { get; set; }
        public string SubTitle { get; set; }
        public string HeadLine { get; set; }
        public string Author { get; set; }
        public DateTime DocumentDate { get; set; }
        public string Teaser { get; set; }
        public string TeaserImage { get; set; }
        public bool UserHomePageOnly { get; set; }
        public string TeaserTitle{ get; set; }
        public string TeaserButtonText { get; set; }
        public bool TeaserOpenInNewWindow { get; set; }
        public bool TeaserShare { get; set; }
        public string TeaserfullButtonLinkURL { get; set; }
        public string MainText { get; set; }
        public string MetaDescription { get; set; }
        public List<string> ImagesURL { get; set; }
        public bool SpanImagesAcross { get; set; }
        public string Aling { get; set; }
        public bool WrapTextAroundImage { get; set; }
        public List<ContentDocument> Documents { get; set; }
        public Video Video { get; set; }
        public Audio Audio { get; set; }
        public string SearchTags { get; set; }

    }

    public class ContentDocument
    {
        public string FileURL { get; set; }
        public bool ShowTermsOfUse { get; set; }
        public string Title { get; set; }
    }

    public class Video
    {
        public string FileURL { get; set; }
    }

    public class Audio
    {
        public string FileURL { get; set; }
        public string AudioArtist { get; set; }
        public bool HideAudioArtistInfo { get; set; }
        public bool AutoStartAudio { get; set; }
        public bool Loop { get; set; }
        public bool DisplayAnimation { get; set; }
        public int InitialVolume { get; set; }
    }

    public class DisplayOptions
    {
        public bool ShowComment { get; set; }
        public bool NoNewComments { get; set; }
        public List<Category> categories { get; set; }
        public int DisplayOption { get; set; }
        public int HomePageFeature { get; set; }
        public bool UnlockedPost { get; set; }
        public bool MLSSearch { get; set; }
        public bool PackageTemplate { get; set; }
        public int PostType{ get; set; }
    }
}
