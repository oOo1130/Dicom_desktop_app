using Dicom;
using System;
using System.Threading.Tasks;

namespace RIS.Storage
{
    /// <summary>
    /// The storage access interface.
    /// </summary>
    public interface IStorageAccess
    {
        /// <summary>
        /// Creates a directory.
        /// </summary>
        /// <param name="path">The directory path.</param>
        Task CreateDirectoryAsync(String path);

        /// <summary>
        /// Checks the existence of a directory.
        /// </summary>
        /// <param name="path">The directory path.</param>
        /// <returns>Whether the directory exists or not.</returns>
        Task<bool> DirectoryExistsAsync(String path);

        /// <summary>
        /// Deletes a directory.
        /// </summary>
        /// <param name="path">The directory path.</param>
        /// <param name="recursive">Perform the operation recursively.</param>
        Task DeleteDirectoryAsync(String path, bool recursive);

        /// <summary>
        /// Persists a DICOM dataset to the file system.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="dicomDataset">The DICOM dataset.</param>
        Task PersistDicomDatasetInStorageAsync(String path, DicomDataset dicomDataset);

        /// <summary>
        /// Persists a DICOM file object to the file system.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="dicomFile">The DICOM file object.</param>
        Task PersistDicomFileInStorageAsync(String path, DicomFile dicomFile);

        /// <summary>
        /// Queries a DICOM dataset from the file system.
        /// </summary>
        /// <param name="path">The path.</param>
        Task<DicomDataset> QueryDicomDatasetFromStorageAsync(String path);

        /// <summary>
        /// Queries a DICOM file object from the file system.
        /// </summary>
        /// <param name="path">The path.</param>
        Task<DicomFile> QueryDicomFileFromStorageAsync(String path);

        /// <summary>
        /// Checks the existence of a DICOM dataset in the file system.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>Whether the DICOM dataset exists or not.</returns>
        Task<bool> DicomDatasetExistsOnStorageAsync(String path);

        /// <summary>
        /// Copies a DICOM file.
        /// </summary>
        /// <param name="from">The source path.</param>
        /// <param name="to">The destination path.</param>
        /// <param name="overwrite">Flag indicating whether to overwrite the destination file.</param>
        Task CopyDicomFileFromStorageToStorageAsync(String from, String to, bool overwrite);

    }
}
