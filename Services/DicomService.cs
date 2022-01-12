using Dicom;
using RIS.Models;
using RIS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS.Services
{
    public class DicomService
    {
        internal Task<List<DatabaseDataset>> QueryStudyDatabaseDatasetsForUIAsync(DicomDataset qyeryDatasets)
        {
            return new DicomRepository().QueryStudyDatabaseDatasetsForUIAsync(qyeryDatasets);
        }

        internal Task<List<DatabaseDataset>> QueryStudyDatabaseDatasetsForMoveAsync(DicomDataset moveDataset)
        {
            return new DicomRepository().QueryStudyDatabaseDatasetsForMoveAsync(moveDataset);
        }
    }
}
