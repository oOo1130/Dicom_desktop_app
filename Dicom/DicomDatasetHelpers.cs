using Dicom;
using System;

namespace DicomServer
{
    /// <summary>
    /// This class contains helpers to easily create DICOM query/update datasets.
    /// </summary>
    public class DicomDatasetHelpers
    {
        #region Public Methods

        /// <summary>
        /// Create a study query DICOM dataset object from the provided information.
        /// </summary>
        /// <param name="patientId">The patient id.</param>
        /// <param name="patientName">The patient name.</param>
        /// <param name="from">The lower date object.</param>
        /// <param name="to">The higher date object.</param>
        /// <param name="modality">The modality.</param>
        /// <param name="tenant">The modality.</param>
        /// <returns>The created DICOM dataset object.</returns>
        public static DicomDataset CreateStudyQueryDicomDataset(String patientId, String patientName,
            DateTime? from, DateTime? to, String modality, String tenant)
        {
            var dateQuery = String.Empty;
            if (from.HasValue || to.HasValue)
                dateQuery = String.Format("{0}-{1}",
                    from.HasValue ? from.Value.ToString("yyyyMMdd") : String.Empty,
                    to.HasValue ? to.Value.ToString("yyyyMMdd") : String.Empty);
            if ((from.HasValue && to.HasValue) &&
                from.Value.Date == to.Value.Date)
                dateQuery = from.Value.ToString("yyyyMMdd");

            return new DicomDataset
            {
                { DicomTag.PatientID, patientId },
                { DicomTag.PatientName, patientName },
                { DicomTag.StudyDate, dateQuery },
                { DicomTag.ModalitiesInStudy, modality },
                { DicomTag.InstitutionName, tenant }
            };
        }

        /// <summary>
        /// Create a study move DICOM dataset object from the provided information.
        /// </summary>
        /// <param name="studyInstanceUid">The study instance UID.</param>
        /// <returns>The created DICOM dataset object.</returns>
        public static DicomDataset CreateStudyMoveDicomDataset(String studyInstanceUid)
        {
            return new DicomDataset
            {
                { DicomTag.StudyInstanceUID, studyInstanceUid }
            };
        }



        /// <summary>
        /// Create a study move select dataset object from the provided information.
        /// </summary>
        /// <param name="studyInstanceUid">The study instance UID.</param>
        /// <returns>The created DICOM dataset object.</returns>
        public static DicomDataset CreateStudyQueryDicomDatasetByUID(String studyInstanceUid)
        {
            return new DicomDataset
            {
                { DicomTag.StudyInstanceUID, studyInstanceUid }
            };
        }


        /// <summary>
        /// Create a study delete DICOM dataset object from the provided information.
        /// </summary>
        /// <param name="studyInstanceUid">The study instance UID.</param>
        /// <returns>The created DICOM dataset object.</returns>
        public static DicomDataset CreateStudyDeleteDicomDataset(String studyInstanceUid)
        {
            return new DicomDataset
            {
                { DicomTag.StudyInstanceUID, studyInstanceUid }
            };
        }

        #endregion
    }
}
