using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;



namespace UdownloadList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {


            string playlistId = pid.Text;

            // Replace with the download path
            string downloadPath = path.Text;

            try
            {
                var youtubeService = new YouTubeService(new BaseClientService.Initializer
                {
                    ApiKey = "AIzaSyDGSGz4rv4C255j5kDH0pKMwnDRvoL1Vus"
                });

                var playlistItems = new List<PlaylistItem>();
                string pageToken = null;

                do
                {
                    var playlistItemsListRequest = youtubeService.PlaylistItems.List("snippet");
                    playlistItemsListRequest.PlaylistId = playlistId;
                    playlistItemsListRequest.MaxResults = 50;
                    playlistItemsListRequest.PageToken = pageToken;

                    var playlistItemsListResponse = await playlistItemsListRequest.ExecuteAsync();

                    playlistItems.AddRange(playlistItemsListResponse.Items);
                    pageToken = playlistItemsListResponse.NextPageToken;
                } while (!string.IsNullOrEmpty(pageToken));

                // Create the download directory if it doesn't exist
                Directory.CreateDirectory(downloadPath);

                // Download each video in the playlist
                foreach (var playlistItem in playlistItems)
                {
                    var videoId = playlistItem.Snippet.ResourceId.VideoId;
                    var videoFileName = $"{playlistItem.Snippet.Title}.mp4";
                    var videoFilePath = Path.Combine(downloadPath, videoFileName);
                    Doutput.Text += "---------------------------Trace List Downloading Please Wait-------------------------------- ";
                    Doutput.Text += $"Downloading video: {playlistItem.Snippet.Title}";


                    // Use YoutubeExplode to download the video stream
                    var youtube = new YoutubeClient();
                    var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoId);
                    var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                    await youtube.Videos.Streams.DownloadAsync(streamInfo, videoFilePath);
                    Doutput.Text += $"Downloaded video: {playlistItem.Snippet.Title}";
                    Doutput.Text += "-----------------------------------------------------------------------------";


                }
                Doutput.Text = $"Playlist downloaded successfully! go to {path.Text} to review  ";

            }
            catch (Exception ex)
            {

                Doutput.Text = $"Error downloading playlist: {ex.Message}";
            }


        }



    }
}
