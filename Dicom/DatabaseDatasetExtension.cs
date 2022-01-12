using Dicom;
using Dicom.Data;
using System;

namespace RIS.Models
{
    /// <summary>
    /// This class contains helper methods to transform database datasets to DICOM datasets and vice-versa.
    /// </summary>
    public partial class DatabaseDataset
    {
        #region Private Variables

        /// <summary>
        /// The count of the grouped database datasets.
        /// </summary>
        private int _count;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets/sets the count of the grouped database datasets.
        /// </summary>
        /// <value>The count of the grouped database datasets.</value>
       
        public int ImgCount
        {
            get { return _count; }
            set { _count = value; }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Creates a database dataset from the given DICOM dataset.
        /// </summary>
        /// <param name="dicomDataset">The DICOM dataset.</param>
        /// <param name="path">The relative path of the physical file.</param>
        /// <param name="receptionDate">The reception date.</param>
        /// <param name="receptionAet">The reception AE title.</param>
        /// <param name="receptionAet">The tenant.</param>
        /// <returns>The created database dataset.</returns>
        public static DatabaseDataset CreateDatabaseDatasetFromDicomDataset(DicomDataset dicomDataset, String path,
            DateTime receptionDate, String receptionAet, int tenantId)
        {
            var databaseDataset = new DatabaseDataset();

            if (dicomDataset == null)
                throw new Exception("DicomDataset is null");

            var patientId = dicomDataset.Get<String>(DicomTag.PatientID, String.Empty);
            if (String.IsNullOrWhiteSpace(patientId))
                throw new Exception("PatientID cannot be null or empty");
            databaseDataset.PatientId = patientId;

            var patientName = dicomDataset.Get<String>(DicomTag.PatientName, String.Empty);
            if (String.IsNullOrWhiteSpace(patientName))
                throw new Exception("PatientName cannot be null or empty");
            databaseDataset.PatientName = patientName;

            var patientBirthday =
                dicomDataset.GetNullableDateTime(DicomTag.PatientBirthDate, DicomTag.PatientBirthTime);
            databaseDataset.PatientBirthdate = patientBirthday;

            var patientSex = dicomDataset.Get<String>(DicomTag.PatientSex, String.Empty);
            databaseDataset.PatientSex = patientSex;

            var accessionNumber = dicomDataset.Get<String>(DicomTag.AccessionNumber, String.Empty);
            databaseDataset.AccessionNumber = accessionNumber;

            var studyDescription = dicomDataset.Get<String>(DicomTag.StudyDescription, String.Empty);
            databaseDataset.StudyDescription = studyDescription;

            var seriesDescription = dicomDataset.Get<String>(DicomTag.SeriesDescription, String.Empty);
            databaseDataset.SeriesDescription = seriesDescription;

            var studyId = dicomDataset.Get<String>(DicomTag.StudyID, String.Empty);
            databaseDataset.StudyId = studyId;

            var studyDate =
                dicomDataset.GetNullableDateTime(DicomTag.StudyDate, DicomTag.StudyTime);
            databaseDataset.StudyDate = studyDate.GetValueOrDefault();

            var seriesDate =
                dicomDataset.GetNullableDateTime(DicomTag.SeriesDate, DicomTag.SeriesTime);
            databaseDataset.SeriesDate = seriesDate;

            var modality = dicomDataset.Get<String>(DicomTag.Modality, String.Empty);
            databaseDataset.Modality = modality;

            var seriesNumber = dicomDataset.Get<String>(DicomTag.SeriesNumber, String.Empty);
            databaseDataset.SeriesNumber = seriesNumber;

            var studyInstanceUid = dicomDataset.Get<String>(DicomTag.StudyInstanceUID);
            if (String.IsNullOrWhiteSpace(studyInstanceUid))
                throw new Exception("StudyInstanceUID is missing");
            databaseDataset.StudyInstanceUid = studyInstanceUid;

            var seriesInstanceUid = dicomDataset.Get<String>(DicomTag.SeriesInstanceUID);
            if (String.IsNullOrWhiteSpace(seriesInstanceUid))
                throw new Exception("SeriesInstanceUID is missing");
            databaseDataset.SeriesInstanceUid = seriesInstanceUid;

            var sopInstanceUid = dicomDataset.Get<String>(DicomTag.SOPInstanceUID);
            if (String.IsNullOrWhiteSpace(sopInstanceUid))
                throw new Exception("SOPInstanceUID is missing");
            databaseDataset.SopInstanceUid = sopInstanceUid;

            var sopClassUid = dicomDataset.Get<String>(DicomTag.SOPClassUID, String.Empty);
            databaseDataset.SopClassUid = sopClassUid;

            var instanceNumber = dicomDataset.Get<String>(DicomTag.InstanceNumber, String.Empty);
            databaseDataset.InstanceNumber = instanceNumber;

            var instanceDate =
                dicomDataset.GetNullableDateTime(DicomTag.InstanceCreationDate, DicomTag.InstanceCreationTime);
            databaseDataset.InstanceDateTime = instanceDate;

            databaseDataset.DatasetPath = path;
            databaseDataset.ReceptionDateTime = receptionDate;
            databaseDataset.ReceptionAet = receptionAet;
            databaseDataset.TenantId = tenantId;

            return databaseDataset;
        }

        /// <summary>
        /// Creates a DICOM dataset from the given database dataset.
        /// </summary>
        /// <param name="databaseDataset">The database dataset.</param>
        /// <param name="queryDataset">The query DICOM dataset used to determine which level of
        /// information to include in the create DICOM dataset.</param>
        /// <param name="retrieveAet">The retrieve AE title.</param>
        /// <returns>The created DICOM dataset.</returns>
        public static DicomDataset CreateDicomDatasetFromDatabaseDatasetAndQueryDataset(
            DatabaseDataset databaseDataset, DicomDataset queryDataset, String retrieveAet)
        {
            var dicomDataset = new DicomDataset();
            var queryLevel = queryDataset.Get<String>(DicomTag.QueryRetrieveLevel, String.Empty);
            if (!String.IsNullOrWhiteSpace(queryLevel))
            {
                dicomDataset.Add(DicomTag.RetrieveAETitle, retrieveAet);
                dicomDataset.Add(DicomTag.QueryRetrieveLevel, queryLevel);

                if (queryLevel == "STUDY")
                {
                    dicomDataset.Add(DicomTag.PatientID, databaseDataset.PatientId);
                    dicomDataset.Add(DicomTag.PatientName, databaseDataset.PatientName);
                    if (databaseDataset.PatientBirthdate.HasValue)
                        dicomDataset.Add(DicomTag.PatientBirthDate, databaseDataset.PatientBirthdate.Value);
                    dicomDataset.Add(DicomTag.PatientSex, databaseDataset.PatientSex);
                    dicomDataset.Add(DicomTag.AccessionNumber, databaseDataset.AccessionNumber);
                    //if (databaseDataset.StudyDate.HasValue)
                    //{
                        dicomDataset.Add(DicomTag.StudyDate, databaseDataset.StudyDate);
                        dicomDataset.Add(DicomTag.StudyTime, databaseDataset.StudyDate);
                    //}

                    dicomDataset.Add(DicomTag.StudyDescription, databaseDataset.StudyDescription);
                    dicomDataset.Add(DicomTag.StudyID, databaseDataset.StudyId);
                    dicomDataset.Add(DicomTag.StudyInstanceUID, databaseDataset.StudyInstanceUid);
                    dicomDataset.Add(DicomTag.ModalitiesInStudy, databaseDataset.Modality);
                    dicomDataset.Add(DicomTag.NumberOfStudyRelatedInstances, databaseDataset.ImgCount);
                }

                if (queryLevel == "SERIES")
                {
                    dicomDataset.Add(DicomTag.StudyInstanceUID, databaseDataset.StudyInstanceUid);
                    if (databaseDataset.SeriesDate.HasValue)
                    {
                        dicomDataset.Add(DicomTag.SeriesDate, databaseDataset.SeriesDate.Value);
                        dicomDataset.Add(DicomTag.SeriesTime, databaseDataset.SeriesDate.Value);
                    }

                    dicomDataset.Add(DicomTag.Modality, databaseDataset.Modality);
                    dicomDataset.Add(DicomTag.SeriesNumber, databaseDataset.SeriesNumber);
                    dicomDataset.Add(DicomTag.SeriesDescription, databaseDataset.SeriesDescription);
                    dicomDataset.Add(DicomTag.SeriesInstanceUID, databaseDataset.SeriesInstanceUid);
                    dicomDataset.Add(DicomTag.NumberOfSeriesRelatedInstances, databaseDataset.ImgCount);
                }

                if (queryLevel == "IMAGE")
                {
                    dicomDataset.Add(DicomTag.SOPInstanceUID, databaseDataset.SopInstanceUid);
                    dicomDataset.Add(DicomTag.InstanceNumber, databaseDataset.InstanceNumber);
                }
            }

            return dicomDataset;
        }

        #endregion
    }
}
