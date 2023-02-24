namespace Congratulator.WebApp.Helpers
{
    public class ImageProvider
    {
        private readonly IWebHostEnvironment _appEnvironment;

        public ImageProvider(IWebHostEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }

        public string? SaveFile(IFormFile file)
        {
            if (file != null)
            {
                var folderPath = Path.Combine(_appEnvironment.WebRootPath + "/images/avatars/");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                var fileName = Guid.NewGuid() + "." + file.FileName.Split('.').Last();
                var path = Path.Combine(folderPath, fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                return "/images/avatars/" + fileName;
            }
            return null;
        }
    }
}
