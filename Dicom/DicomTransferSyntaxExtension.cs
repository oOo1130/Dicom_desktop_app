using System;

namespace Dicom
{
    /// <summary>
    /// This class extends the DICOM transfer syntax class to easily check for 
    /// image storage compression.
    /// </summary>
    public static class DicomTransferSyntaxExtension
    {
        #region Public Methods

        /// <summary>
        /// Checks if the DICOM transfer syntax corresponds to compressed image storage.
        /// </summary>
        /// <param name="tx">The DICOM transfer syntax object.</param>
        public static bool IsImageCompression(this DicomTransferSyntax tx)
        {
            return tx != DicomTransferSyntax.ImplicitVRLittleEndian &&
                   tx != DicomTransferSyntax.ExplicitVRLittleEndian &&
                   tx != DicomTransferSyntax.ExplicitVRBigEndian &&
                   tx != DicomTransferSyntax.DeflatedExplicitVRLittleEndian;
        }

        #endregion
    }
}
