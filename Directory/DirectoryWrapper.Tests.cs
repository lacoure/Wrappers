namespace Terrasoft.Common.Tests
{
	using System.IO;
	using NUnit.Framework;

	#region Class: DirectoryWrapperTestCase

	[TestFixture]
	public class DirectoryWrapperTestCase : BaseCommonTestCase
	{

		#region Methods: Public

		[Test, Category("PreCommit")]
		public void GetFiles_CallsGetFilesFromIODirectory() {
			var directoryWrapper = new DirectoryWrapper();
			var searchOption = SearchOption.TopDirectoryOnly;
			const string searchPattern = "*.*";
			string rootFileContent = "RootFileContent RootFileContent";
			string rootDirectoryPath = Path.Combine(OutputPath, "RootDirectory");
			Directory.CreateDirectory(rootDirectoryPath);
			string rootFilePath = Path.Combine(rootDirectoryPath, "RootFileName");
			File.WriteAllText(rootFilePath, rootFileContent);
			string[] actualFiles = directoryWrapper.GetFiles(rootDirectoryPath, searchPattern, searchOption);
			string[] expectedFiles = Directory.GetFiles(rootDirectoryPath, searchPattern, searchOption);
			Assert.AreEqual(actualFiles, expectedFiles);
		}

		[TearDown]
		public void TearDown() {
			if (Directory.Exists(OutputPath)) {
				Directory.Delete(OutputPath, true);
			}
		}

		#endregion

	}

	#endregion

}
