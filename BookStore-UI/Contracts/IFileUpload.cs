using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlazorInputFile;

namespace BookStore_UI.Contracts
{
    public interface IFileUpload
    {
        public Task UploadFile(IFileListEntry file, string picName);
        public void UploadFile(IFileListEntry file, MemoryStream msFile, string picName);
        public void RemoveFile(string picName);
    }
}
