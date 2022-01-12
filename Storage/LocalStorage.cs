using Dicom;
using System;
using System.IO;
using System.Threading.Tasks;

namespace RIS.Storage
{
    /// <summary>
    /// This class implements the storage access interface providing means to
    /// read/write from/to the local storage files and directories.
    /// </summary>
    public class LocalStorage : IStorageAccess
    {
        #region Public Methods

        /// <summary>
        /// Creates a directory.
        /// </summary>
        /// <param name="path">The directory path.</param>
        public async Task CreateDirectoryAsync(String path)
        {
            if (String.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Path is null or empty");

            await CreateFolderAsync(path);
        }

        /// <summary>
        /// Checks the existence of a directory.
        /// </summary>
        /// <param name="path">The directory path.</param>
        /// <returns>Whether the directory exists or not.</returns>
        public async Task<bool> DirectoryExistsAsync(String path)
        {
            if (String.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Path is null or empty");

            return await FolderExistsAsync(path);
        }

        /// <summary>
        /// Deletes a directory.
        /// </summary>
        /// <param name="path">The directory path.</param>
        /// <param name="recursive">Perform the operation recursively.</param>
        public async Task DeleteDirectoryAsync(String path, bool recursive)
        {
            if (String.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Path is null or empty");

            await DeleteFolderAsync(path, recursive);
        }

        /// <summary>
        /// Persists a DICOM dataset to the file system.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="dicomDataset">The DICOM dataset.</param>
        public async Task PersistDicomDatasetInStorageAsync(String path, DicomDataset dicomDataset)
        {
            if (String.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Path is null or empty");

            if (dicomDataset == null)
                throw new ArgumentException("DicomDataset is null");

            var dicomFile = new DicomFile(dicomDataset);
            await dicomFile.SaveAsync(path);
        }

        /// <summary>
        /// Persists a DICOM file object to the file system.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="dicomFile">The DICOM file object.</param>
        public async Task PersistDicomFileInStorageAsync(String path, DicomFile dicomFile)
        {
            if (String.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Path is null or empty");

            if (dicomFile == null)
                throw new ArgumentException("DicomFile is null");

            await dicomFile.SaveAsync(path);
        }

        /// <summary>
        /// Queries a DICOM dataset from the file system.
        /// </summary>
        /// <param name="path">The path.</param>
        public async Task<DicomDataset> QueryDicomDatasetFromStorageAsync(String path)
        {
            var dicomFile = await DicomFile.OpenAsync(path);
            return dicomFile.Dataset;
        }

        /// <summary>
        /// Queries a DICOM file object from the file system.
        /// </summary>
        /// <param name="path">The path.</param>
        public async Task<DicomFile> QueryDicomFileFromStorageAsync(String path)
        {
            return await DicomFile.OpenAsync(path);
        }

        /// <summary>
        /// Checks the existence of a DICOM dataset in the file system.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>Whether the DICOM dataset exists or not.</returns>
        public async Task<bool> DicomDatasetExistsOnStorageAsync(String path)
        {
            return await FileExistsAsync(path);
        }

        /// <summary>
        /// Copies a DICOM file.
        /// </summary>
        /// <param name="from">The source path.</param>
        /// <param name="to">The destination path.</param>
        /// <param name="overwrite">Flag indicating whether to overwrite the destination file.</param>
        public async Task CopyDicomFileFromStorageToStorageAsync(String from, String to, bool overwrite)
        {
            await FileCopyAsync(from, to, overwrite);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Creates a directory.
        /// </summary>
        /// <param name="path">The directory path.</param>
        private Task CreateFolderAsync(String path)
        {
            return Task.Run(() => Directory.CreateDirectory(path));
        }

        /// <summary>
        /// Checks the existence of a directory.
        /// </summary>
        /// <param name="path">The directory path.</param>
        /// <returns>Whether the directory exists or not.</returns>
        private Task<bool> FolderExistsAsync(String path)
        {
            return Task.Run(() => Directory.Exists(path));
        }

        /// <summary>
        /// Deletes a directory.
        /// </summary>
        /// <param name="path">The directory path.</param>
        /// <param name="recursive">Perform the operation recursively.</param>
        private Task DeleteFolderAsync(String path, bool recursive)
        {
            return Task.Run(() => Directory.Delete(path, recursive));
        }

        /// <summary>
        /// Checks the existence of a file in the file system.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>Whether the file exists or not.</returns>
        private Task<bool> FileExistsAsync(String path)
        {
            return Task.Run(() => File.Exists(path));
        }

        /// <summary>
        /// Copies a file.
        /// </summary>
        /// <param name="from">The source path.</param>
        /// <param name="to">The destination path.</param>
        /// <param name="overwrite">Flag indicating whether to overwrite the destination file.</param>
        private Task FileCopyAsync(String from, String to, bool overwrite)
        {
            return Task.Run(() => File.Copy(from, to, overwrite));
        }

        #endregion
    }
}
