namespace Terrasoft.Common
{

	#region Interface: IFileReader

	/// <summary>
	/// Provides methods for the reading of a single file.
	/// </summary>
	internal interface IFileReader
	{

		#region Methods: Internal

		/// <summary>
		/// Opens a binary file, reads the contents of the file into a byte array, and then closes the file.
		/// </summary>
		/// <param name="path">The file to open for reading. </param>
		/// <returns>
		/// A byte array containing the contents of the file.
		/// </returns>
		byte[] ReadAllBytes(string path);

		#endregion

	}

	#endregion

}
