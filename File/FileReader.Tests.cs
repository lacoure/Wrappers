namespace Terrasoft.Common.Tests
{
	using System.IO;
	using NUnit.Framework;

	#region Class: FileReaderTestCase

	[TestFixture]
	public class FileReaderTestCase : BaseCommonTestCase
	{

		#region Methods: Public

		[Test, Category("PreCommit")]
		public void ReadAllBytes_CallsReadAllBytesFromIOFile() {
			const string rootFileContent = "RootFileContent RootFileContent";
			string rootFilePath = Path.Combine(OutputPath, "RootFileName");
			File.WriteAllText(rootFilePath, rootFileContent);
			var fileReader = new FileReader();
			byte[] actualBytes = fileReader.ReadAllBytes(rootFilePath);
			byte[] expectedBytes = File.ReadAllBytes(rootFilePath);
			Assert.AreEqual(actualBytes, expectedBytes);
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
