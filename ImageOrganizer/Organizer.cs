using NReco.VideoInfo;
using System.Text;

namespace ImageOrganizer
{
    public class Organizer
    {

        private readonly int DATE_TAKEN_TAG_ID = 0x9003;
        private readonly string[] _imageExtensions = { "jpg", "jpeg", "png", "gif", "bmp", "wmf", "emf" };
        private readonly string[] _videoEtensions = { "mp4", "mkv" };

        public IList<string> Files { get; set; } = new List<string>();

        public IList<string> GetFileList(string path)
        {
            Files = FindFilesRecursivelyWithPermission(path);

            return Files;
        }

        public void Do(string origin, string target, string filename, ListBox lstStatus)
        {
            var extension = Path.GetExtension(filename).Replace(".", string.Empty).ToLower();

            if (_imageExtensions.Contains(extension))
            {
                var date = GetPictureDateTaken(filename);
                ProcessFile(date, origin, target, filename, lstStatus);
            }

            if (_videoEtensions.Contains(extension))
            {
                var date = GetFileDateTime(filename);
                ProcessFile(date, origin, target, filename, lstStatus);
            }

            Console.WriteLine("Fim");
        }

        private void ProcessFile(DateTime date, string origin, string target, string filename, ListBox lstStatus)
        {
            var ano = date.Year.ToString("D4");
            var mes = date.Month.ToString("D2");
            var directory = $"{target}\\{ano}\\{mes}";

            if (!File.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            var file = Path.GetFileName(filename);
            var completeFilename = $"{directory}\\{file}";
            var i = 1;
            while (File.Exists(completeFilename))
            {
                var ext = Path.GetExtension(filename);
                var name = filename.Replace(ext, string.Empty);

                filename = $"{name}_{i}.{ext}";
                completeFilename = $"{directory}\\{filename}";
            }

            lstStatus.Items.Insert(0, $"Para: {directory}");
            lstStatus.Items.Insert(0, $"Movendo o arquivo {filename}");
            lstStatus.Items.Insert(0, string.Empty);

            File.Move(filename, completeFilename);
        }

        private IList<string> FindFilesRecursivelyWithPermission(string rootPath, string stringDefault = "*.*")
        {
            var pendingPaths = new Queue<string>();
            var foundFiles = new List<string>();

            pendingPaths.Enqueue(rootPath);

            while (pendingPaths.Count > 0)
            {
                var actualPath = pendingPaths.Dequeue();

                try
                {
                    var fileList = Directory.GetFiles(actualPath, stringDefault);

                    foundFiles.AddRange(fileList);

                    foreach (var subDirectory in Directory.GetDirectories(actualPath))
                    {
                        pendingPaths.Enqueue(subDirectory);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    // Ignorar exceções sobre acesso não autorizado.
                }
            }

            return foundFiles;
        }

        private DateTime GetPictureDateTaken(string file)
        {
            // Include date time taken like this [DT:date format]
            using Image img = Image.FromFile(file);
            try
            {
                var dateBytes = img.GetPropertyItem(DATE_TAKEN_TAG_ID)?.Value;

                if (dateBytes == null)
                {
                    return File.GetCreationTime(file);
                }

                var dateTakenTag = Encoding.ASCII.GetString(dateBytes);
                var parts = dateTakenTag.Split(':', ' ');
                var year = int.Parse(parts[0]);
                var month = int.Parse(parts[1]);
                var day = int.Parse(parts[2]);
                var hour = int.Parse(parts[3]);
                var minute = int.Parse(parts[4]);
                var second = int.Parse(parts[5]);

                return new DateTime(year, month, day, hour, minute, second);
            }
            catch (Exception)
            {
                return File.GetCreationTime(file);
            }
        }

        private DateTime GetFileDateTime(string file)
        {
            try
            {
                var ffProbe = new FFProbe();
                var videoInfo = ffProbe.GetMediaInfo(file);
                return DateTime.Parse(videoInfo.FormatTags[3].Value);
            }
            catch (Exception)
            {
                return File.GetCreationTime(file);
            }
        }

    }
}