namespace Terrasoft.Common
{
	using System.IO;

	#region Class: DirectoryWrapper

	/// <summary>
	/// System.IO.Directory wrapper.
	/// </summary>
	internal class DirectoryWrapper : IDirectory
	{

		#region Methods: Public

		/// <summary>
		/// Returns the names of files (including their paths) that match the specified search pattern in the specified
		/// directory, using a value to determine whether to search subdirectories.
		/// </summary>
		/// <param name="path">The relative or absolute path to the directory to search. This string is not
		/// case-sensitive.</param>
		/// <param name="searchPattern">The search string to match against the names of files in
		/// <paramref name="path"/>. This parameter can contain a combination of valid literal path and
		/// wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions.</param>
		/// <param name="searchOption">One of the enumeration values that specifies whether the search operation should
		/// include all subdirectories or only the current directory. </param>
		/// <returns>
		/// An array of the full names (including paths) for the files in the specified directory that match the
		/// specified search pattern and option, or an empty array if no files are found.
		/// </returns>
		public string[] GetFiles(string path, string searchPattern, SearchOption searchOption) {
			return Directory.GetFiles(path, searchPattern, searchOption);
		}

		#endregion

	}

	#endregion

}
