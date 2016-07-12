namespace Terrasoft.Common
{
	using System.IO;

	#region Class: FileReader

	/// <summary>
	/// System.IO.File wrapper.
	/// </summary>
	internal class FileReader : IFileReader
	{

		#region Methods: Public

		/// <summary>
		/// Opens a binary file, reads the contents of the file into a byte array, and then closes the file.
		/// </summary>
		/// <param name="path">The file to open for reading. </param>
		/// <returns>
		/// A byte array containing the contents of the file.
		/// </returns>
		public byte[] ReadAllBytes(string path) {
			return File.ReadAllBytes(path);
		}

		#endregion

	}

	#endregion

}
