using Dicom;
using RIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RIS.Repositories
{
    public class DicomRepository
    {
        internal Task<List<DatabaseDataset>> QueryStudyDatabaseDatasetsForUIAsync(DicomDataset qyeryDatasets)
        {

            if (qyeryDatasets == null)
                throw new ArgumentException("DicomDataset is null");

            var t = new TaskCompletionSource<List<DatabaseDataset>>();
            QueryStudyDatabaseDatasetsForUI(qyeryDatasets,
                r => { t.TrySetResult(r); },
                e => { t.TrySetException(e); });

            return t.Task;
        }

        public Task<List<DatabaseDataset>> QueryStudyDatabaseDatasetsForMoveAsync(DicomDataset queryDataset
           )
        {
            if (queryDataset == null)
                throw new ArgumentException("DicomDataset is null");

            var t = new TaskCompletionSource<List<DatabaseDataset>>();
            QueryStudyDatabaseDatasetsForMove(queryDataset,
                r => { t.TrySetResult(r); },
                e => { t.TrySetException(e); });

            return t.Task;
        }

        private void QueryStudyDatabaseDatasetsForMove(DicomDataset queryDataset, Action<List<DatabaseDataset>> success, Action<Exception> failure)
        {
            ThreadPool.QueueUserWorkItem((_) =>
            {
                try
                {
                    var databaseDatasets = new List<DatabaseDataset>();
                    
                   using (var context = new DICOMServerDbContext())
                   {
                           var queriedDatabaseDatasets = context.DatabaseDatasets
                              .Where(FilterByStudyInstanceUid(queryDataset, false))
                                .OrderByDescending(p => p.ReceptionDateTime);
                            databaseDatasets.AddRange(queriedDatabaseDatasets);
                   }
                    

                    success(databaseDatasets);
                }
                catch (Exception ex)
                {
                    failure(ex);
                }
            });
        }

        private void QueryStudyDatabaseDatasetsForUI(DicomDataset queryDataset, Action<List<DatabaseDataset>> success, Action<Exception> failure)
        {
            ThreadPool.QueueUserWorkItem((_) =>
            {
                try
                {
                    var databaseDatasets = new List<DatabaseDataset>();

                    using (DICOMServerDbContext context = new DICOMServerDbContext())
                    {
                        var queriedDatabaseDatasets = context.DatabaseDatasets
                         .Where(FilterByStudyInstanceUid(queryDataset)).ToList();

                        success(queriedDatabaseDatasets);
                    }
                    

                   
                }
                catch (Exception ex)
                {
                    failure(ex);
                }
            });
        }

        private static Expression<Func<DatabaseDataset, bool>> FilterByStudyInstanceUid(DicomDataset queryDataset,
            bool matchAll = true)
        {
            Expression<Func<DatabaseDataset, bool>> allMatch = d => matchAll;

            var value = queryDataset.Get<String>(DicomTag.StudyInstanceUID, null);
            if (String.IsNullOrWhiteSpace(value))
                return allMatch;

            return d => d.StudyInstanceUid == value;
        }
    }
}
