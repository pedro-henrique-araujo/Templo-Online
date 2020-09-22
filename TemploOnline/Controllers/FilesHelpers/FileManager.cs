using System;
using System.IO;
using System.Net;
using Microsoft.AspNetCore.Hosting;

namespace TemploOnline.FilesHelpers
{
  public class FileManager
  {
    private IWebHostEnvironment _env;
    public FileManager(IWebHostEnvironment env)
    {
      _env = env;
    }

    public string DownloadImg(string imgUrl)
    {
      var displayPath = "/images/classrooms/" + DateTime.Now.Ticks + ".png";
      var path = _env.WebRootPath + displayPath;
      using (var client = new WebClient())
      {
        client.DownloadFile(new Uri(imgUrl), path);
      }
      return displayPath;
    }

    public bool DeleteImg(string displayPath)
    {
      var path = _env.WebRootPath + displayPath;
      var file = new FileInfo(path);
      if (file.Exists)
      {
        file.Delete();
        return true;
      }
      return false;
    }
  }
}